namespace ProjectTurAgency.Forms
{
    partial class FormTourCompilation
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
            numericUpDownTourId = new NumericUpDown();
            dateTimePickerCompilationDate = new DateTimePicker();
            buttonCancel = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTourId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 39);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Тур ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 87);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Дата:";
            // 
            // numericUpDownTourId
            // 
            numericUpDownTourId.Location = new Point(109, 31);
            numericUpDownTourId.Name = "numericUpDownTourId";
            numericUpDownTourId.Size = new Size(161, 23);
            numericUpDownTourId.TabIndex = 2;
            // 
            // dateTimePickerCompilationDate
            // 
            dateTimePickerCompilationDate.Location = new Point(109, 79);
            dateTimePickerCompilationDate.Name = "dateTimePickerCompilationDate";
            dateTimePickerCompilationDate.Size = new Size(161, 23);
            dateTimePickerCompilationDate.TabIndex = 3;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(178, 171);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(70, 171);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormTourCompilation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 230);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(dateTimePickerCompilationDate);
            Controls.Add(numericUpDownTourId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTourCompilation";
            Text = "Формарование туров";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTourId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownTourId;
        private DateTimePicker dateTimePickerCompilationDate;
        private Button buttonCancel;
        private Button buttonSave;
    }
}