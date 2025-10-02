namespace ProjectTurAgency.Forms
{
    partial class FormContract
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
            comboBoxClient = new ComboBox();
            comboBoxTour = new ComboBox();
            comboBoxDiscount = new ComboBox();
            dateTimePickerDate = new DateTimePicker();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Клиент:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 72);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Тур:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 114);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Скидка:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 155);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Дата";
            // 
            // comboBoxClient
            // 
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(107, 22);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(121, 23);
            comboBoxClient.TabIndex = 4;
            // 
            // comboBoxTour
            // 
            comboBoxTour.FormattingEnabled = true;
            comboBoxTour.Location = new Point(107, 64);
            comboBoxTour.Name = "comboBoxTour";
            comboBoxTour.Size = new Size(121, 23);
            comboBoxTour.TabIndex = 5;
            // 
            // comboBoxDiscount
            // 
            comboBoxDiscount.FormattingEnabled = true;
            comboBoxDiscount.Location = new Point(107, 106);
            comboBoxDiscount.Name = "comboBoxDiscount";
            comboBoxDiscount.Size = new Size(121, 23);
            comboBoxDiscount.TabIndex = 6;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(107, 147);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(120, 23);
            dateTimePickerDate.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(62, 225);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(171, 225);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // FormContract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 301);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(dateTimePickerDate);
            Controls.Add(comboBoxDiscount);
            Controls.Add(comboBoxTour);
            Controls.Add(comboBoxClient);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormContract";
            Text = "FormContract";
            Load += FormContract_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxClient;
        private ComboBox comboBoxTour;
        private ComboBox comboBoxDiscount;
        private DateTimePicker dateTimePickerDate;
        private Button buttonSave;
        private Button buttonCancel;
    }
}