using System.Drawing;

namespace Tamagotchi
{
    public partial class Form1 : Form
    {
        private Plant? _plant;
        private System.Windows.Forms.Timer _fadeTimer;
        private FadeEffect _fadeEffect;
        private System.Windows.Forms.Timer _decayTimer;
        private PlantPersistence _persistence;
        private Dictionary<PlantState, Image> _plantSprites = new();
        public Form1()
        {
            InitializeComponent();

            plantName_label.Location = new Point(
                (this.ClientSize.Width - plantName_label.Width) / 2,
                plantName_label.Location.Y
            );

            // загрузка спрайты
            try
            {
                var baseDir = Path.GetDirectoryName(Application.ExecutablePath)!;
                var imagesDir = Path.Combine(baseDir, "Images");

                _plantSprites[PlantState.Blooming] = Properties.Resources.plant_blooming;
                _plantSprites[PlantState.Healthy] = Properties.Resources.plant_healthy;
                _plantSprites[PlantState.Wilting] = Properties.Resources.plant_wilting;
                _plantSprites[PlantState.Dead] = Properties.Resources.plant_dead;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки спрайтов: {ex.Message}", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            _persistence = new PlantPersistence();

            // таймер для анимации
            _fadeTimer = new System.Windows.Forms.Timer { Interval = 40 };
            // эффект затухания: от PaleGoldenrod к фону SeaGreen
            _fadeEffect = new FadeEffect(_fadeTimer, Color.PaleGoldenrod, Color.SeaGreen);

            // таймер для деградации параметров
            _decayTimer = new System.Windows.Forms.Timer { Interval = 60_000 };
            _decayTimer.Tick += DecayTimer_Tick;

            this.FormClosing += Form1_FormClosing;
        }

        private void myPlant_btn_Click(object sender, EventArgs e)
        {
            //double minutesPassed = 0;

            if (_plant == null)
            {
                _plant = _persistence.Load();

                if (_plant == null)
                {
                    using var nameForm = new PlantNameForm();
                    if (nameForm.ShowDialog() == DialogResult.OK)
                    {
                        _plant = new Plant(nameForm.PlantName);
                    }
                    else
                    {
                        return;
                    }
                }

                // деградация за пропущенное время
                var minutesPassed = (DateTime.Now - _plant.LastUpdate).TotalMinutes;
                if (minutesPassed > 0)
                {
                    _plant.ApplyDecay(minutesPassed);
                }
            }

            //MessageBox.Show(
            //    $"Прошло минут: {minutesPassed:F1}\n" +
            //    $"Влажность: {_plant?.Moisture:F1}\n" +
            //    $"Питание: {_plant?.Nutrition:F1}\n" +
            //    $"Свет: {_plant?.Light:F1}",
            //    "Отладка: Деградация при загрузке"
            //);

            // проверка на смерть растения вне игры
            if (_plant.IsDead)
            {
                _decayTimer.Stop();
                MessageBox.Show(
                    "Твоё растение умерло... 😢\nНачни заново!",
                    "Увы...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                _persistence.DeleteSaveFile();
                _plant = null;
                return;
            }

            UpdatePlantUI();

            start_panel.Visible = false;
            main_panel.Visible = true;

            _decayTimer.Start();
        }

        private void UpdatePlantUI()
        {
            if (_plant == null) return;

            plantName_label.Text = _plant.PlantName;

            // обновление прогресс баров
            var (moisture, nutrition, light) = _plant.GetProgressValues();
            moisture_progressBar.Value = moisture;
            nutrition_progressBar.Value = nutrition;
            light_progressBar.Value = light;

            var state = _plant.GetVisualState();
            if (_plantSprites.TryGetValue(state, out var sprite))
            {
                plant_pictureBox.Image = sprite;
            }
            else
            {
                // если спрайта нет то используется цвет
                plant_pictureBox.Image = null;
                plant_pictureBox.BackColor = _plant.GetBackgroundColor();
            }

            // проверка на смерть растения во время игры
            if (_plant.IsDead)
            {
                _decayTimer.Stop();

                MessageBox.Show(
                    "Твоё растение умерло... 😢\nНачни заново!",
                    "Увы...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                start_panel.Visible = true;
                main_panel.Visible = false;
                _persistence.DeleteSaveFile();
                _plant = null;
                return;
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backMenu_label_Click(object sender, EventArgs e)
        {
            start_panel.Visible = true;
            main_panel.Visible = false;

            _decayTimer.Stop();
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

        // деградация параметров
        private void DecayTimer_Tick(object sender, EventArgs e)
        {
            if (_plant == null) return;

            _plant.ApplyDecay(1); // именно 1 минута

            UpdatePlantUI();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_plant != null && !_plant.IsDead)
            {
                var minutesPassed = (DateTime.Now - _plant.LastUpdate).TotalMinutes;
                if (minutesPassed > 0)
                {
                    _plant.ApplyDecay(minutesPassed);
                }
                _persistence.Save(_plant);
            }

            _decayTimer?.Stop();
            _fadeTimer?.Stop();
        }

        private void killButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Уверены, что хотите сжечь кактус?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                _persistence.DeleteSaveFile();
                _plant = null;
                start_panel.Visible = true;
                main_panel.Visible = false;
            }
        }
    }
}
