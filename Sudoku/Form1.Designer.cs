namespace Sudoku
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
            mainPanel = new Panel();
            label2 = new Label();
            newGameBtn = new Button();
            continueBtn = new Button();
            label1 = new Label();
            newGamePanel = new Panel();
            sudokuTable = new TableLayoutPanel();
            exitBtn = new Button();
            resetBtn = new Button();
            pencilBtn = new Button();
            solveBtn = new Button();
            helpBtn = new Button();
            mainPanel.SuspendLayout();
            newGamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(newGameBtn);
            mainPanel.Controls.Add(continueBtn);
            mainPanel.Controls.Add(label1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(511, 692);
            mainPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(235, 253);
            label2.Name = "label2";
            label2.Size = new Size(42, 45);
            label2.TabIndex = 3;
            label2.Text = "~";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // newGameBtn
            // 
            newGameBtn.BackColor = Color.Navy;
            newGameBtn.Cursor = Cursors.Hand;
            newGameBtn.FlatStyle = FlatStyle.Popup;
            newGameBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newGameBtn.ForeColor = Color.White;
            newGameBtn.Location = new Point(94, 478);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(329, 57);
            newGameBtn.TabIndex = 2;
            newGameBtn.Text = "New game";
            newGameBtn.UseVisualStyleBackColor = false;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // continueBtn
            // 
            continueBtn.BackColor = Color.Navy;
            continueBtn.Cursor = Cursors.Hand;
            continueBtn.FlatStyle = FlatStyle.Popup;
            continueBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            continueBtn.ForeColor = Color.White;
            continueBtn.Location = new Point(94, 396);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(329, 57);
            continueBtn.TabIndex = 1;
            continueBtn.Text = "Continue";
            continueBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(94, 126);
            label1.Name = "label1";
            label1.Size = new Size(329, 90);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the \r\nworld of Sudoku!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // newGamePanel
            // 
            newGamePanel.Controls.Add(sudokuTable);
            newGamePanel.Controls.Add(exitBtn);
            newGamePanel.Controls.Add(resetBtn);
            newGamePanel.Controls.Add(pencilBtn);
            newGamePanel.Controls.Add(solveBtn);
            newGamePanel.Controls.Add(helpBtn);
            newGamePanel.Dock = DockStyle.Fill;
            newGamePanel.Location = new Point(0, 0);
            newGamePanel.Name = "newGamePanel";
            newGamePanel.Size = new Size(511, 692);
            newGamePanel.TabIndex = 1;
            newGamePanel.Visible = false;
            // 
            // sudokuTable
            // 
            sudokuTable.BackColor = Color.LightSteelBlue;
            sudokuTable.ColumnCount = 9;
            sudokuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sudokuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sudokuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            sudokuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            sudokuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            sudokuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            sudokuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            sudokuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            sudokuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            sudokuTable.Location = new Point(79, 61);
            sudokuTable.Name = "sudokuTable";
            sudokuTable.RowCount = 9;
            sudokuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            sudokuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            sudokuTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sudokuTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sudokuTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sudokuTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sudokuTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sudokuTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sudokuTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sudokuTable.Size = new Size(356, 356);
            sudokuTable.TabIndex = 7;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Maroon;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.FlatStyle = FlatStyle.Popup;
            exitBtn.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(270, 582);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(165, 48);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.Navy;
            resetBtn.Cursor = Cursors.Hand;
            resetBtn.FlatStyle = FlatStyle.Popup;
            resetBtn.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetBtn.ForeColor = Color.White;
            resetBtn.Location = new Point(79, 582);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(165, 48);
            resetBtn.TabIndex = 5;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            // 
            // pencilBtn
            // 
            pencilBtn.BackColor = Color.Navy;
            pencilBtn.Cursor = Cursors.Hand;
            pencilBtn.FlatStyle = FlatStyle.Popup;
            pencilBtn.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pencilBtn.ForeColor = Color.White;
            pencilBtn.Location = new Point(79, 468);
            pencilBtn.Name = "pencilBtn";
            pencilBtn.Size = new Size(90, 48);
            pencilBtn.TabIndex = 4;
            pencilBtn.Text = "Pencil";
            pencilBtn.UseVisualStyleBackColor = false;
            // 
            // solveBtn
            // 
            solveBtn.BackColor = Color.Navy;
            solveBtn.Cursor = Cursors.Hand;
            solveBtn.FlatStyle = FlatStyle.Popup;
            solveBtn.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            solveBtn.ForeColor = Color.White;
            solveBtn.Location = new Point(345, 468);
            solveBtn.Name = "solveBtn";
            solveBtn.Size = new Size(90, 48);
            solveBtn.TabIndex = 3;
            solveBtn.Text = "Solve";
            solveBtn.UseVisualStyleBackColor = false;
            // 
            // helpBtn
            // 
            helpBtn.BackColor = Color.Navy;
            helpBtn.Cursor = Cursors.Hand;
            helpBtn.FlatStyle = FlatStyle.Popup;
            helpBtn.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            helpBtn.ForeColor = Color.White;
            helpBtn.Location = new Point(214, 468);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new Size(90, 48);
            helpBtn.TabIndex = 2;
            helpBtn.Text = "Help";
            helpBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(511, 692);
            Controls.Add(newGamePanel);
            Controls.Add(mainPanel);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 4, 6, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "~ SUDOKU ~";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            newGamePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label label1;
        private Button continueBtn;
        private Label label2;
        private Button newGameBtn;
        private Panel newGamePanel;
        private Button helpBtn;
        private Button pencilBtn;
        private Button solveBtn;
        private Button exitBtn;
        private Button resetBtn;
        private TableLayoutPanel sudokuTable;
    }
}
