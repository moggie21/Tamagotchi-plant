namespace Tamagotchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myPlant_btn_Click(object sender, EventArgs e)
        {
            start_panel.Visible = false;
            main_panel.Visible = true;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backMenu_label_Click(object sender, EventArgs e)
        {
            start_panel.Visible = true;
            main_panel.Visible = false;
        }
    }
}
