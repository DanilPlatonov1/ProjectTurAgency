namespace ProjectTurAgency.Forms
{
    partial class FormTour
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
            numericUpDownPrice = new NumericUpDown();
            buttonCancel = new Button();
            buttonSave = new Button();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxRoute = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(140, 85);
            numericUpDownPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(171, 23);
            numericUpDownPrice.TabIndex = 16;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(178, 227);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(63, 227);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(140, 33);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(171, 23);
            textBoxName.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 144);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 11;
            label3.Text = "Маршрут:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 93);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "Цена:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 41);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 9;
            label1.Text = "Название:";
            // 
            // comboBoxRoute
            // 
            comboBoxRoute.FormattingEnabled = true;
            comboBoxRoute.Location = new Point(140, 136);
            comboBoxRoute.Name = "comboBoxRoute";
            comboBoxRoute.Size = new Size(171, 23);
            comboBoxRoute.TabIndex = 17;
            // 
            // FormTour
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 284);
            Controls.Add(comboBoxRoute);
            Controls.Add(numericUpDownPrice);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTour";
            Text = "Новый тур";
            Load += FormTour_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownPrice;
        private Button buttonCancel;
        private Button buttonSave;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxRoute;
    }
}