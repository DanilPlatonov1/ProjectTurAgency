namespace ProjectTurAgency.Forms
{
    partial class FormDiscount
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
            textBoxDescription = new TextBox();
            numericUpDownPercent = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPercent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Описание:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 85);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Проценты:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(114, 25);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(169, 23);
            textBoxDescription.TabIndex = 2;
            // 
            // numericUpDownPercent
            // 
            numericUpDownPercent.Location = new Point(114, 77);
            numericUpDownPercent.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPercent.Name = "numericUpDownPercent";
            numericUpDownPercent.Size = new Size(169, 23);
            numericUpDownPercent.TabIndex = 3;
            numericUpDownPercent.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(64, 198);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(174, 198);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // FormDiscount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 252);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownPercent);
            Controls.Add(textBoxDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDiscount";
            Text = "Новая скидка";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPercent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxDescription;
        private NumericUpDown numericUpDownPercent;
        private Button buttonSave;
        private Button buttonCancel;
    }
}