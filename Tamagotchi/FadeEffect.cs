using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class FadeEffect
    {
        private readonly System.Windows.Forms.Timer _timer;
        private Label? _targetLabel;
        private int _currentStep;
        private readonly int _totalSteps;
        private readonly Color _startColor;
        private readonly Color _endColor;

        // конструктор: принимает таймер с формы1
        public FadeEffect(System.Windows.Forms.Timer timer, Color startColor, Color endColor, int totalSteps = 20)
        {
            _timer = timer ?? throw new ArgumentNullException(nameof(timer));
            _startColor = startColor;
            _endColor = endColor;
            _totalSteps = totalSteps;

            _timer.Tick -= OnTimerTick;
            _timer.Tick += OnTimerTick;
        }

        public void Start(Label label)
        {
            if (label == null) return;

            Stop();

            _targetLabel = label;
            _currentStep = 0;

            label.Visible = true;
            label.ForeColor = _startColor;

            _timer.Start();
        }

        public void Stop()
        {
            if (_targetLabel != null)
            {
                _targetLabel.Visible = false;
                _targetLabel = null;
            }
            _timer.Stop();
            _currentStep = 0;
        }

        private void OnTimerTick(object? sender, EventArgs e)
        {
            if (_targetLabel == null) return;

            _currentStep++;

            if (_currentStep >= _totalSteps)
            {
                Stop();
            }
            else
            {
                double t = (double)_currentStep / _totalSteps;
                var r = (int)(_startColor.R * (1 - t) + _endColor.R * t);
                var g = (int)(_startColor.G * (1 - t) + _endColor.G * t);
                var b = (int)(_startColor.B * (1 - t) + _endColor.B * t);
                _targetLabel.ForeColor = Color.FromArgb(r, g, b);
            }
        }
    }
}
