namespace ProjectTurAgency
{
    partial class FormAgency
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            клиентыToolStripMenuItem = new ToolStripMenuItem();
            контрактыToolStripMenuItem = new ToolStripMenuItem();
            скидкиToolStripMenuItem = new ToolStripMenuItem();
            маршрутыToolStripMenuItem = new ToolStripMenuItem();
            скидкиToolStripMenuItem1 = new ToolStripMenuItem();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            подпиасниеДоговораToolStripMenuItem = new ToolStripMenuItem();
            отчетыToolStripMenuItem = new ToolStripMenuItem();
            DirectoryReportToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, операцииToolStripMenuItem, отчетыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { клиентыToolStripMenuItem, контрактыToolStripMenuItem, скидкиToolStripMenuItem, маршрутыToolStripMenuItem, скидкиToolStripMenuItem1 });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(94, 20);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // клиентыToolStripMenuItem
            // 
            клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            клиентыToolStripMenuItem.Size = new Size(136, 22);
            клиентыToolStripMenuItem.Text = "Клиенты";
            клиентыToolStripMenuItem.Click += ClientsToolStripMenuItem_Click;
            // 
            // контрактыToolStripMenuItem
            // 
            контрактыToolStripMenuItem.Name = "контрактыToolStripMenuItem";
            контрактыToolStripMenuItem.Size = new Size(136, 22);
            контрактыToolStripMenuItem.Text = "Контракты";
            контрактыToolStripMenuItem.Click += ContractsToolStripMenuItem_Click;
            // 
            // скидкиToolStripMenuItem
            // 
            скидкиToolStripMenuItem.Name = "скидкиToolStripMenuItem";
            скидкиToolStripMenuItem.Size = new Size(136, 22);
            скидкиToolStripMenuItem.Text = "Туры";
            скидкиToolStripMenuItem.Click += ToursToolStripMenuItem_Click;
            // 
            // маршрутыToolStripMenuItem
            // 
            маршрутыToolStripMenuItem.Name = "маршрутыToolStripMenuItem";
            маршрутыToolStripMenuItem.Size = new Size(136, 22);
            маршрутыToolStripMenuItem.Text = "Маршруты";
            маршрутыToolStripMenuItem.Click += RoutesToolStripMenuItem_Click;
            // 
            // скидкиToolStripMenuItem1
            // 
            скидкиToolStripMenuItem1.Name = "скидкиToolStripMenuItem1";
            скидкиToolStripMenuItem1.Size = new Size(136, 22);
            скидкиToolStripMenuItem1.Text = "Скидки";
            скидкиToolStripMenuItem1.Click += DiscountsToolStripMenuItem_Click;
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { подпиасниеДоговораToolStripMenuItem });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(75, 20);
            операцииToolStripMenuItem.Text = "Операции";
            // 
            // подпиасниеДоговораToolStripMenuItem
            // 
            подпиасниеДоговораToolStripMenuItem.Name = "подпиасниеДоговораToolStripMenuItem";
            подпиасниеДоговораToolStripMenuItem.Size = new Size(196, 22);
            подпиасниеДоговораToolStripMenuItem.Text = "Подпиасние договора";
            подпиасниеДоговораToolStripMenuItem.Click += ContractSigningsToolStripMenuItem_Click;
            // 
            // отчетыToolStripMenuItem
            // 
            отчетыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DirectoryReportToolStripMenuItem });
            отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            отчетыToolStripMenuItem.Size = new Size(60, 20);
            отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // DirectoryReportToolStripMenuItem
            // 
            DirectoryReportToolStripMenuItem.Name = "DirectoryReportToolStripMenuItem";
            DirectoryReportToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            DirectoryReportToolStripMenuItem.Size = new Size(280, 22);
            DirectoryReportToolStripMenuItem.Text = "Документ со справочниками";
            DirectoryReportToolStripMenuItem.Click += DirectoryReportToolStripMenuItem_Click;
            // 
            // FormAgency
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ostrov_more_tsvety_1317968_1920x1080;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 411);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormAgency";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Туристичекое агентство";
            Load += FormAgency_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem контрактыToolStripMenuItem;
        private ToolStripMenuItem скидкиToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
        private ToolStripMenuItem маршрутыToolStripMenuItem;
        private ToolStripMenuItem скидкиToolStripMenuItem1;
        private ToolStripMenuItem подпиасниеДоговораToolStripMenuItem;
        private ToolStripMenuItem DirectoryReportToolStripMenuItem;
    }
}
