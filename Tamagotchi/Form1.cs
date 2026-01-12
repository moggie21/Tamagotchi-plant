using System.Drawing;

namespace Tamagotchi
{
    public partial class Form1 : Form
    {
        private Plant? _plant;
        private System.Windows.Forms.Timer _fadeTimer;
        private FadeEffect _fadeEffect;
        public Form1()
        {
            InitializeComponent();

            // таймер для анимации
            _fadeTimer = new System.Windows.Forms.Timer { Interval = 30 };
            // эффект затухания: от PaleGoldenrod к фону SeaGreen
            _fadeEffect = new FadeEffect(_fadeTimer, Color.PaleGoldenrod, Color.SeaGreen);
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
            _fadeEffect.Start(addMoisture_label);
            UpdatePlantUI();
        }

        private void feed_btn_Click(object sender, EventArgs e)
        {
            _plant?.Feed();
            _fadeEffect.Start(addNutrition_label);
            UpdatePlantUI();
        }

        private void light_btn_Click(object sender, EventArgs e)
        {
            _plant?.GiveLight();
            _fadeEffect.Start(addLight_label);
            UpdatePlantUI();
        }
    }
}
