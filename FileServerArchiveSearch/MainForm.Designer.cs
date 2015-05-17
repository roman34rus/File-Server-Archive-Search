namespace FileServerArchiveSearch
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ArchDirLabel = new System.Windows.Forms.Label();
            this.ArchDirPath = new System.Windows.Forms.TextBox();
            this.OpenArchDir = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchString = new System.Windows.Forms.TextBox();
            this.StartSearch = new System.Windows.Forms.Button();
            this.SearchFolders = new System.Windows.Forms.RadioButton();
            this.SearchFiles = new System.Windows.Forms.RadioButton();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.Copyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultList = new System.Windows.Forms.ListBox();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArchDirLabel
            // 
            this.ArchDirLabel.AutoSize = true;
            this.ArchDirLabel.Location = new System.Drawing.Point(13, 13);
            this.ArchDirLabel.Name = "ArchDirLabel";
            this.ArchDirLabel.Size = new System.Drawing.Size(203, 13);
            this.ArchDirLabel.TabIndex = 0;
            this.ArchDirLabel.Text = "Где ищем: путь к каталогу с архивами";
            // 
            // ArchDirPath
            // 
            this.ArchDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArchDirPath.Location = new System.Drawing.Point(13, 30);
            this.ArchDirPath.Name = "ArchDirPath";
            this.ArchDirPath.Size = new System.Drawing.Size(678, 20);
            this.ArchDirPath.TabIndex = 1;
            // 
            // OpenArchDir
            // 
            this.OpenArchDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenArchDir.Location = new System.Drawing.Point(697, 30);
            this.OpenArchDir.Name = "OpenArchDir";
            this.OpenArchDir.Size = new System.Drawing.Size(75, 23);
            this.OpenArchDir.TabIndex = 2;
            this.OpenArchDir.Text = "Открыть";
            this.OpenArchDir.UseVisualStyleBackColor = true;
            this.OpenArchDir.Click += new System.EventHandler(this.OpenArchDir_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(13, 57);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(305, 13);
            this.SearchLabel.TabIndex = 3;
            this.SearchLabel.Text = "Что ищем: имя файла или каталога (можно с частью пути)";
            // 
            // SearchString
            // 
            this.SearchString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchString.Location = new System.Drawing.Point(13, 74);
            this.SearchString.Name = "SearchString";
            this.SearchString.Size = new System.Drawing.Size(678, 20);
            this.SearchString.TabIndex = 4;
            // 
            // StartSearch
            // 
            this.StartSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartSearch.Location = new System.Drawing.Point(697, 74);
            this.StartSearch.Name = "StartSearch";
            this.StartSearch.Size = new System.Drawing.Size(75, 23);
            this.StartSearch.TabIndex = 5;
            this.StartSearch.Text = "Поиск";
            this.StartSearch.UseVisualStyleBackColor = true;
            this.StartSearch.Click += new System.EventHandler(this.StartSearch_Click);
            // 
            // SearchFolders
            // 
            this.SearchFolders.AutoSize = true;
            this.SearchFolders.Checked = true;
            this.SearchFolders.Location = new System.Drawing.Point(13, 101);
            this.SearchFolders.Name = "SearchFolders";
            this.SearchFolders.Size = new System.Drawing.Size(111, 17);
            this.SearchFolders.TabIndex = 6;
            this.SearchFolders.TabStop = true;
            this.SearchFolders.Text = "Искать каталоги";
            this.SearchFolders.UseVisualStyleBackColor = true;
            // 
            // SearchFiles
            // 
            this.SearchFiles.AutoSize = true;
            this.SearchFiles.Location = new System.Drawing.Point(130, 100);
            this.SearchFiles.Name = "SearchFiles";
            this.SearchFiles.Size = new System.Drawing.Size(99, 17);
            this.SearchFiles.TabIndex = 7;
            this.SearchFiles.Text = "Искать файлы";
            this.SearchFiles.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Copyright});
            this.Status.Location = new System.Drawing.Point(0, 539);
            this.Status.Name = "Status";
            this.Status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Status.Size = new System.Drawing.Size(784, 22);
            this.Status.TabIndex = 11;
            // 
            // Copyright
            // 
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(200, 17);
            this.Copyright.Text = "Copyright © 2014, Любимов Роман";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(10, 121);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(395, 13);
            this.ResultLabel.TabIndex = 12;
            this.ResultLabel.Text = "Результаты поиска (двойной клик покажет файл или каталог в проводнике)";
            // 
            // ResultList
            // 
            this.ResultList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultList.FormattingEnabled = true;
            this.ResultList.Location = new System.Drawing.Point(13, 137);
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(759, 394);
            this.ResultList.TabIndex = 13;
            this.ResultList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ResultList_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ResultList);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.SearchFiles);
            this.Controls.Add(this.SearchFolders);
            this.Controls.Add(this.StartSearch);
            this.Controls.Add(this.SearchString);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.OpenArchDir);
            this.Controls.Add(this.ArchDirPath);
            this.Controls.Add(this.ArchDirLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Server Archive Search";
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArchDirLabel;
        private System.Windows.Forms.TextBox ArchDirPath;
        private System.Windows.Forms.Button OpenArchDir;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchString;
        private System.Windows.Forms.Button StartSearch;
        private System.Windows.Forms.RadioButton SearchFolders;
        private System.Windows.Forms.RadioButton SearchFiles;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel Copyright;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.ListBox ResultList;
    }
}

