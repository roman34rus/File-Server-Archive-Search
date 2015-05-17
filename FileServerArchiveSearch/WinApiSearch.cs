using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace FileServerArchiveSearch
{
    /// <summary>
    /// Класс для поиска файлов и каталогов средствами WinAPI.
    /// Поддерживаются пути длиннее 260 символов.
    /// </summary>
    public static class WinApiSearch
    {
        #region Определение констант и структур WinAPI.

        private const int MAX_PATH = 260;
        private const int MAX_ALTERNATE = 14;

        [StructLayout(LayoutKind.Sequential)]
        private struct FILETIME
        {
            public uint dwLowDateTime;
            public uint dwHighDateTime;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct WIN32_FIND_DATA
        {
            public FileAttributes dwFileAttributes;
            public FILETIME ftCreationTime;
            public FILETIME ftLastAccessTime;
            public FILETIME ftLastWriteTime;
            public uint nFileSizeHigh;
            public uint nFileSizeLow;
            public uint dwReserved0;
            public uint dwReserved1;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string cFileName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_ALTERNATE)]
            public string cAlternate;
        }

        #endregion

        #region Импорт функций WinAPI для поиска файлов.
        
        // Импортируются unicode-версии, что позволяет работать с длинными путями.

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern IntPtr FindFirstFile(string lpFileName, out WIN32_FIND_DATA lpFindFileData);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern bool FindNextFile(IntPtr hFindFile, out WIN32_FIND_DATA lpFindFileData);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern bool FindClose(IntPtr hFindFile);

        #endregion

        #region Вспомогательные методы.

        /// <summary>
        /// Проверка наличия подстроки в строке без учета регистра.
        /// </summary>
        /// <param name="_str1">Строка в которой ищем.</param>
        /// <param name="_str2">Подстрока, которую ищем.</param>
        /// <returns></returns>
        private static bool StringContains(string _str1, string _str2)
        {
            if (_str1.IndexOf(_str2, StringComparison.CurrentCultureIgnoreCase) == -1)
                return false;
            else
                return true;
        }

        #endregion

        /// <summary>
        /// Рекурсивный поиск в заданном каталоге.
        /// </summary>
        /// <param name="_searchPath">Каталог поиска.</param>
        /// <param name="_searchString">Строка поиска.</param>
        /// <param name="_searchFolders">Искать каталоги.</param>
        /// <param name="_searchFiles">Искать файлы.</param>
        /// <returns>Список найденных файлов/каталогов с полными путями.</returns>
        public static List<string> RecurseSearch(string _searchPath, string _searchString, bool _searchFolders, bool _searchFiles)
        {
            // Результаты поиска.
            List<string> results = new List<string>();

            // Удаляем из пути к каталогу поиска завершающие "\".
            string searchPath = Regex.Replace(_searchPath, @"\\+$", @"");
            
            // Вспомогательныые переменные для поиска.
            IntPtr findHandle;
            IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
            WIN32_FIND_DATA findData;

            // Запускаем цикл поиска.
            // К каталогу поиска добавляем "\*" чтобы получить все подкаталоги и файлы.
            findHandle = FindFirstFile(searchPath + @"\*", out findData);

            if (findHandle != INVALID_HANDLE_VALUE)
            {
                do
                {
                    // Пропускаем каталоги "." и "..".
                    if ((findData.cFileName == ".") || (findData.cFileName == ".."))
                        continue;

                    // Пропускаем точки повторной обработки (symlink и  т.д.).
                    if ((findData.dwFileAttributes & FileAttributes.ReparsePoint) == FileAttributes.ReparsePoint)
                        continue;

                    // Получаем полное имя.
                    string fullName = searchPath + @"\" + findData.cFileName;

                    // Если найден подкаталог.
                    if ((findData.dwFileAttributes & FileAttributes.Directory) != 0)
                    {
                        // Если ищем каталоги и имя текущего содержит строку поиска - добавляем к результатам.
                        if ((_searchFolders) && StringContains(fullName, _searchString))
                            results.Add(fullName);

                        // Рекурсивно ищем внутри подкаталога.
                        results.AddRange(RecurseSearch(fullName, _searchString, _searchFolders, _searchFiles));
                    }

                    // Если найден файл.
                    else
                    {
                        // Если ищем файлы и имя текущего содержит строку поиска - добавляем к результатам.
                        if ((_searchFiles) && StringContains(fullName, _searchString))
                            results.Add(fullName);
                    }
                }
                while (FindNextFile(findHandle, out findData));

                // Завершаем цикл поиска.
                FindClose(findHandle);             
            }

            // Возвращаем результаты.
            return results;
        }
    }
}
