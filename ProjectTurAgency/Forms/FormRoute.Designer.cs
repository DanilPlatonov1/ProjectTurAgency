namespace ProjectTurAgency.Forms
{
    partial class FormRoute
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
            textBoxStart = new TextBox();
            textBoxEnd = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            numericUpDownDuration = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Начальная точка:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 85);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Конечная точка:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 136);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Кол-во дней:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(155, 25);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(171, 23);
            textBoxStart.TabIndex = 3;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(155, 77);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(171, 23);
            textBoxEnd.TabIndex = 4;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(83, 219);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(190, 219);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // numericUpDownDuration
            // 
            numericUpDownDuration.Location = new Point(155, 128);
            numericUpDownDuration.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            numericUpDownDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDuration.Name = "numericUpDownDuration";
            numericUpDownDuration.Size = new Size(171, 23);
            numericUpDownDuration.TabIndex = 8;
            numericUpDownDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormRoute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 271);
            Controls.Add(numericUpDownDuration);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxEnd);
            Controls.Add(textBoxStart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRoute";
            Text = "Новый маршрут";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxStart;
        private TextBox textBoxEnd;
        private Button buttonSave;
        private Button buttonCancel;
        private NumericUpDown numericUpDownDuration;
    }
}