namespace ProjectTurAgency.Forms
{
    partial class FormContractSigning
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
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            dateTimePickerSigningDate = new DateTimePicker();
            comboBoxContracts = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 30);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Контракт:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 171);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 72);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 6;
            label6.Text = "Дата:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(175, 139);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(290, 139);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // dateTimePickerSigningDate
            // 
            dateTimePickerSigningDate.Enabled = false;
            dateTimePickerSigningDate.Location = new Point(112, 66);
            dateTimePickerSigningDate.Name = "dateTimePickerSigningDate";
            dateTimePickerSigningDate.Size = new Size(387, 23);
            dateTimePickerSigningDate.TabIndex = 10;
            // 
            // comboBoxContracts
            // 
            comboBoxContracts.FormattingEnabled = true;
            comboBoxContracts.Location = new Point(112, 22);
            comboBoxContracts.Name = "comboBoxContracts";
            comboBoxContracts.Size = new Size(387, 23);
            comboBoxContracts.TabIndex = 13;
            // 
            // FormContractSigning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 195);
            Controls.Add(comboBoxContracts);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(dateTimePickerSigningDate);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Name = "FormContractSigning";
            Text = "Подписание контракта";
            Load += FormContractSigning_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private Label label6;
        private Button buttonSave;
        private Button buttonCancel;
        private DateTimePicker dateTimePickerSigningDate;
        private ComboBox comboBoxContracts;
    }
}