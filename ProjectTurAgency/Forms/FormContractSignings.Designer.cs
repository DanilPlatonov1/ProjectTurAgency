namespace ProjectTurAgency.Forms
{
    partial class FormContractSignings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridViewData = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 35);
            button1.Name = "button1";
            button1.Size = new Size(93, 57);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonAdd_Click;
            // 
            // dataGridViewData
            // 
            dataGridViewData.AllowUserToResizeColumns = false;
            dataGridViewData.AllowUserToResizeRows = false;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Dock = DockStyle.Fill;
            dataGridViewData.Location = new Point(0, 0);
            dataGridViewData.MultiSelect = false;
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.Size = new Size(650, 450);
            dataGridViewData.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(650, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 450);
            panel1.TabIndex = 2;
            // 
            // FormContractSignings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewData);
            Controls.Add(panel1);
            Name = "FormContractSignings";
            Text = "Подписанные контракты";
            Load += FormContractSignings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridViewData;
        private Panel panel1;
    }
}