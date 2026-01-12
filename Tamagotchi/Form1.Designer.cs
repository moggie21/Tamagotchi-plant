namespace Tamagotchi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            start_panel = new Panel();
            label1 = new Label();
            exit_btn = new Button();
            myPlant_btn = new Button();
            main_panel = new Panel();
            backMenu_label = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            nutrition_progressBar = new ProgressBar();
            light_progressBar = new ProgressBar();
            moisture_progressBar = new ProgressBar();
            light_btn = new Button();
            feed_btn = new Button();
            water_btn = new Button();
            plant_pictureBox = new PictureBox();
            start_panel.SuspendLayout();
            main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)plant_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // start_panel
            // 
            start_panel.BackColor = Color.SeaGreen;
            start_panel.Controls.Add(label1);
            start_panel.Controls.Add(myPlant_btn);
            start_panel.Controls.Add(exit_btn);
            start_panel.Dock = DockStyle.Fill;
            start_panel.Location = new Point(0, 0);
            start_panel.Name = "start_panel";
            start_panel.Size = new Size(711, 618);
            start_panel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PaleGoldenrod;
            label1.Location = new Point(317, 424);
            label1.Name = "label1";
            label1.Size = new Size(66, 70);
            label1.TabIndex = 2;
            label1.Text = "~";
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.PaleGoldenrod;
            exit_btn.Cursor = Cursors.Hand;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exit_btn.Location = new Point(162, 293);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(372, 63);
            exit_btn.TabIndex = 1;
            exit_btn.Text = "Выйти";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // myPlant_btn
            // 
            myPlant_btn.BackColor = Color.PaleGoldenrod;
            myPlant_btn.Cursor = Cursors.Hand;
            myPlant_btn.FlatStyle = FlatStyle.Flat;
            myPlant_btn.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            myPlant_btn.Location = new Point(162, 156);
            myPlant_btn.Name = "myPlant_btn";
            myPlant_btn.Size = new Size(372, 63);
            myPlant_btn.TabIndex = 0;
            myPlant_btn.Text = "Моё растение";
            myPlant_btn.UseVisualStyleBackColor = false;
            myPlant_btn.Click += myPlant_btn_Click;
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.SeaGreen;
            main_panel.Controls.Add(backMenu_label);
            main_panel.Controls.Add(label5);
            main_panel.Controls.Add(label4);
            main_panel.Controls.Add(label3);
            main_panel.Controls.Add(label2);
            main_panel.Controls.Add(nutrition_progressBar);
            main_panel.Controls.Add(light_progressBar);
            main_panel.Controls.Add(moisture_progressBar);
            main_panel.Controls.Add(light_btn);
            main_panel.Controls.Add(feed_btn);
            main_panel.Controls.Add(water_btn);
            main_panel.Controls.Add(plant_pictureBox);
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(0, 0);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(711, 618);
            main_panel.TabIndex = 3;
            main_panel.Visible = false;
            // 
            // backMenu_label
            // 
            backMenu_label.AutoSize = true;
            backMenu_label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backMenu_label.ForeColor = Color.PaleGoldenrod;
            backMenu_label.Location = new Point(501, 568);
            backMenu_label.Name = "backMenu_label";
            backMenu_label.Size = new Size(179, 23);
            backMenu_label.TabIndex = 11;
            backMenu_label.Text = "<- Назад в меню";
            backMenu_label.Click += backMenu_label_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PaleGoldenrod;
            label5.Location = new Point(253, 167);
            label5.Name = "label5";
            label5.Size = new Size(184, 27);
            label5.TabIndex = 10;
            label5.Text = "Моё растение";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PaleGoldenrod;
            label4.Location = new Point(37, 91);
            label4.Name = "label4";
            label4.Size = new Size(61, 23);
            label4.TabIndex = 9;
            label4.Text = "Свет";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.PaleGoldenrod;
            label3.Location = new Point(37, 62);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 8;
            label3.Text = "Питание";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.PaleGoldenrod;
            label2.Location = new Point(37, 33);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 7;
            label2.Text = "Влажность";
            // 
            // nutrition_progressBar
            // 
            nutrition_progressBar.Location = new Point(177, 62);
            nutrition_progressBar.Name = "nutrition_progressBar";
            nutrition_progressBar.Size = new Size(260, 23);
            nutrition_progressBar.TabIndex = 6;
            // 
            // light_progressBar
            // 
            light_progressBar.Location = new Point(177, 91);
            light_progressBar.Name = "light_progressBar";
            light_progressBar.Size = new Size(260, 23);
            light_progressBar.TabIndex = 5;
            // 
            // moisture_progressBar
            // 
            moisture_progressBar.Location = new Point(177, 33);
            moisture_progressBar.Name = "moisture_progressBar";
            moisture_progressBar.Size = new Size(260, 23);
            moisture_progressBar.TabIndex = 4;
            // 
            // light_btn
            // 
            light_btn.BackColor = Color.PaleGoldenrod;
            light_btn.Cursor = Cursors.Hand;
            light_btn.FlatStyle = FlatStyle.Flat;
            light_btn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            light_btn.Location = new Point(498, 489);
            light_btn.Name = "light_btn";
            light_btn.Size = new Size(182, 48);
            light_btn.TabIndex = 3;
            light_btn.Text = "Дать свет";
            light_btn.UseVisualStyleBackColor = false;
            // 
            // feed_btn
            // 
            feed_btn.BackColor = Color.PaleGoldenrod;
            feed_btn.Cursor = Cursors.Hand;
            feed_btn.FlatStyle = FlatStyle.Flat;
            feed_btn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            feed_btn.Location = new Point(265, 489);
            feed_btn.Name = "feed_btn";
            feed_btn.Size = new Size(182, 48);
            feed_btn.TabIndex = 2;
            feed_btn.Text = "Подкормить";
            feed_btn.UseVisualStyleBackColor = false;
            // 
            // water_btn
            // 
            water_btn.BackColor = Color.PaleGoldenrod;
            water_btn.Cursor = Cursors.Hand;
            water_btn.FlatStyle = FlatStyle.Flat;
            water_btn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            water_btn.Location = new Point(35, 489);
            water_btn.Name = "water_btn";
            water_btn.Size = new Size(182, 48);
            water_btn.TabIndex = 1;
            water_btn.Text = "Полить";
            water_btn.UseVisualStyleBackColor = false;
            // 
            // plant_pictureBox
            // 
            plant_pictureBox.BackColor = Color.PaleGoldenrod;
            plant_pictureBox.Location = new Point(247, 221);
            plant_pictureBox.Name = "plant_pictureBox";
            plant_pictureBox.Size = new Size(200, 200);
            plant_pictureBox.TabIndex = 0;
            plant_pictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 618);
            Controls.Add(main_panel);
            Controls.Add(start_panel);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My plant";
            start_panel.ResumeLayout(false);
            start_panel.PerformLayout();
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)plant_pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel start_panel;
        private Button myPlant_btn;
        private Button exit_btn;
        private Label label1;
        private Panel main_panel;
        private PictureBox plant_pictureBox;
        private Button water_btn;
        private Button light_btn;
        private Button feed_btn;
        private ProgressBar nutrition_progressBar;
        private ProgressBar light_progressBar;
        private ProgressBar moisture_progressBar;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label backMenu_label;
    }
}
