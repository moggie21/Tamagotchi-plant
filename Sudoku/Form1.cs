namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ShowNewGamePanel()
        {
            mainPanel.Visible = false;
            newGamePanel.Visible = true;
        }

        public void ShowMainPanel()
        {
            newGamePanel.Visible = false;
            mainPanel.Visible = true;
            
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            ShowNewGamePanel();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            ShowMainPanel();
        }
    }
}
