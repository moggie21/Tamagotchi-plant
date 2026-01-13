namespace Tamagotchi
{
    partial class PlantNameForm
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
            okButton = new Button();
            nameTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PaleGoldenrod;
            label1.Location = new Point(94, 31);
            label1.Name = "label1";
            label1.Size = new Size(334, 27);
            label1.TabIndex = 0;
            label1.Text = "Дайте имя своему кактусу:";
            // 
            // okButton
            // 
            okButton.BackColor = Color.PaleGoldenrod;
            okButton.Cursor = Cursors.Hand;
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            okButton.Location = new Point(191, 163);
            okButton.Name = "okButton";
            okButton.Size = new Size(127, 48);
            okButton.TabIndex = 2;
            okButton.Text = "Ок";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(127, 99);
            nameTextBox.MaxLength = 15;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(256, 26);
            nameTextBox.TabIndex = 3;
            // 
            // PlantNameForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(524, 249);
            Controls.Add(nameTextBox);
            Controls.Add(okButton);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PlantNameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlantNameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button okButton;
        private TextBox nameTextBox;
    }
}