namespace ProjectTurAgency.Forms
{
    partial class FormDiscounts
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
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            dataGridViewData = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(30, 200);
            button3.Name = "button3";
            button3.Size = new Size(93, 57);
            button3.TabIndex = 2;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ButtonDel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(30, 35);
            button1.Name = "button1";
            button1.Size = new Size(93, 57);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(30, 118);
            button2.Name = "button2";
            button2.Size = new Size(93, 57);
            button2.TabIndex = 1;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonUpd_Click;
            // 
            // dataGridViewData
            // 
            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.AllowUserToDeleteRows = false;
            dataGridViewData.AllowUserToResizeColumns = false;
            dataGridViewData.AllowUserToResizeRows = false;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Dock = DockStyle.Fill;
            dataGridViewData.Location = new Point(0, 0);
            dataGridViewData.MultiSelect = false;
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.ReadOnly = true;
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewData.Size = new Size(650, 450);
            dataGridViewData.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(650, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 450);
            panel1.TabIndex = 2;
            // 
            // FormDiscounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewData);
            Controls.Add(panel1);
            Name = "FormDiscounts";
            Text = "Скидки";
            Load += FormDiscounts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button1;
        private Button button2;
        private DataGridView dataGridViewData;
        private Panel panel1;
    }
}