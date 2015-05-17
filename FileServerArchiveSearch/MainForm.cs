using System;
using System.IO;
using System.Windows.Forms;

namespace FileServerArchiveSearch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открыть каталог с архивами.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenArchDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            
            dialog.Description = "Открыть каталог с архивами";
            dialog.ShowNewFolderButton = false;

            if (dialog.ShowDialog() == DialogResult.OK)
                ArchDirPath.Text = dialog.SelectedPath;
        }

        /// <summary>
        /// Начать поиск.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartSearch_Click(object sender, EventArgs e)
        {
            // Проверяем доступ к каталогу с архивами.
            if (!Directory.Exists(ArchDirPath.Text))
            {
                MessageBox.Show("Каталог с архивами не существует или к нему нет доступа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Блокируем кнопку поиска.
            StartSearch.Enabled = false;

            // Выполняем рекурсивный поиск в каталоге с архивами.
            ResultList.Items.Clear();
            ResultList.Items.AddRange(WinApiSearch.RecurseSearch(ArchDirPath.Text, SearchString.Text, SearchFolders.Checked, SearchFiles.Checked).ToArray());

            // Разблокируем кнопку поиска.
            StartSearch.Enabled = true;
        }

        /// <summary>
        /// Показать выбранный файл/каталог в проводнике по двойному клику.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ResultList.SelectedItem != null)
            {
                string item = ResultList.SelectedItem.ToString();

                System.Diagnostics.Process.Start("explorer.exe", @"/select, " + item);
            }
        }
    }
}
