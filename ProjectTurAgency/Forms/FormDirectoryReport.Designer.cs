namespace ProjectTurAgency.Forms
{
    partial class FormDirectoryReport
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
            checkBoxClient = new CheckBox();
            checkBoxRoute = new CheckBox();
            checkBoxTour = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBoxClient
            // 
            checkBoxClient.AutoSize = true;
            checkBoxClient.Location = new Point(29, 27);
            checkBoxClient.Name = "checkBoxClient";
            checkBoxClient.Size = new Size(74, 19);
            checkBoxClient.TabIndex = 0;
            checkBoxClient.Text = "Клиенты";
            checkBoxClient.UseVisualStyleBackColor = true;
            // 
            // checkBoxRoute
            // 
            checkBoxRoute.AutoSize = true;
            checkBoxRoute.Location = new Point(29, 52);
            checkBoxRoute.Name = "checkBoxRoute";
            checkBoxRoute.Size = new Size(88, 19);
            checkBoxRoute.TabIndex = 1;
            checkBoxRoute.Text = "Маршруты";
            checkBoxRoute.UseVisualStyleBackColor = true;
            // 
            // checkBoxTour
            // 
            checkBoxTour.AutoSize = true;
            checkBoxTour.Location = new Point(29, 77);
            checkBoxTour.Name = "checkBoxTour";
            checkBoxTour.Size = new Size(54, 19);
            checkBoxTour.TabIndex = 2;
            checkBoxTour.Text = "Туры";
            checkBoxTour.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(147, 38);
            button1.Name = "button1";
            button1.Size = new Size(105, 44);
            button1.TabIndex = 3;
            button1.Text = "Сформировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonBuild_Click;
            // 
            // FormDirectoryReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 125);
            Controls.Add(button1);
            Controls.Add(checkBoxTour);
            Controls.Add(checkBoxRoute);
            Controls.Add(checkBoxClient);
            Name = "FormDirectoryReport";
            Text = "Выгрузка справочников";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxClient;
        private CheckBox checkBoxRoute;
        private CheckBox checkBoxTour;
        private Button button1;
    }
}