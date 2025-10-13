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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDownClientId = new NumericUpDown();
            label6 = new Label();
            numericUpDownTourId = new NumericUpDown();
            numericUpDownDiscountId = new NumericUpDown();
            dateTimePickerSigningDate = new DateTimePicker();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownClientId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTourId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscountId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 36);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Клиент ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 80);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Тур ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 126);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Скидка ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 171);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // numericUpDownClientId
            // 
            numericUpDownClientId.Location = new Point(150, 28);
            numericUpDownClientId.Name = "numericUpDownClientId";
            numericUpDownClientId.Size = new Size(155, 23);
            numericUpDownClientId.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 171);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 6;
            label6.Text = "Дата:";
            // 
            // numericUpDownTourId
            // 
            numericUpDownTourId.Location = new Point(150, 72);
            numericUpDownTourId.Name = "numericUpDownTourId";
            numericUpDownTourId.Size = new Size(155, 23);
            numericUpDownTourId.TabIndex = 7;
            // 
            // numericUpDownDiscountId
            // 
            numericUpDownDiscountId.Location = new Point(150, 118);
            numericUpDownDiscountId.Name = "numericUpDownDiscountId";
            numericUpDownDiscountId.Size = new Size(155, 23);
            numericUpDownDiscountId.TabIndex = 8;
            // 
            // dateTimePickerSigningDate
            // 
            dateTimePickerSigningDate.Location = new Point(150, 163);
            dateTimePickerSigningDate.Name = "dateTimePickerSigningDate";
            dateTimePickerSigningDate.Size = new Size(155, 23);
            dateTimePickerSigningDate.TabIndex = 10;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(78, 263);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(193, 263);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormContractSigning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 322);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(dateTimePickerSigningDate);
            Controls.Add(numericUpDownDiscountId);
            Controls.Add(numericUpDownTourId);
            Controls.Add(label6);
            Controls.Add(numericUpDownClientId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormContractSigning";
            Text = "FormContractSigning";
            Load += FormContractSigning_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownClientId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTourId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscountId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownClientId;
        private Label label6;
        private NumericUpDown numericUpDownTourId;
        private NumericUpDown numericUpDownDiscountId;
        private DateTimePicker dateTimePickerSigningDate;
        private Button buttonSave;
        private Button buttonCancel;
    }
}