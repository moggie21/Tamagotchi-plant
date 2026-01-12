using System.Drawing;

namespace Tamagotchi
{
    public partial class Form1 : Form
    {
        private Plant? _plant;
        public Form1()
        {
            InitializeComponent();
        }

        private void myPlant_btn_Click(object sender, EventArgs e)
        {
            _plant ??= new Plant();
            UpdatePlantUI();

            start_panel.Visible = false;
            main_panel.Visible = true;
        }

        private void UpdatePlantUI()
        {
            if (_plant == null) return;

            // обновление прогресс баров
            var (moisture, nutrition, light) = _plant.GetProgressValues();
            moisture_progressBar.Value = moisture;
            nutrition_progressBar.Value = nutrition;
            light_progressBar.Value = light;

            plant_pictureBox.BackColor = _plant.GetBackgroundColor();
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

        private void water_btn_Click(object sender, EventArgs e)
        {
            _plant?.Water();
            addMoisture_label.Visible = true;
            UpdatePlantUI();
        }

        private void feed_btn_Click(object sender, EventArgs e)
        {
            _plant?.Feed();
            addNutrition_label.Visible = true;
            UpdatePlantUI();
        }

        private void light_btn_Click(object sender, EventArgs e)
        {
            _plant?.GiveLight();
            addLight_label.Visible = true;
            UpdatePlantUI();
        }
    }
}
