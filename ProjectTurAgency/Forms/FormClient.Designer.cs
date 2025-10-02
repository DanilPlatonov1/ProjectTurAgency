namespace ProjectTurAgency.Forms
{
    partial class FormClient
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
            label1 = new Label();
            label2 = new Label();
            textBoxFullName = new TextBox();
            textBoxPhone = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label4 = new Label();
            comboBoxSex = new ComboBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "ФИО:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 136);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Телефон:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(100, 25);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(177, 23);
            textBoxFullName.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(100, 128);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(177, 23);
            textBoxPhone.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 189);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Почта:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(100, 181);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(177, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 85);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 6;
            label4.Text = "Пол:";
            // 
            // comboBoxSex
            // 
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Location = new Point(100, 77);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(177, 23);
            comboBoxSex.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(66, 274);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(174, 274);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 326);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxSex);
            Controls.Add(label4);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxFullName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormClient";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Новый клиент";
            Load += FormClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxFullName;
        private TextBox textBoxPhone;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label4;
        private ComboBox comboBoxSex;
        private Button buttonSave;
        private Button buttonCancel;
    }
}