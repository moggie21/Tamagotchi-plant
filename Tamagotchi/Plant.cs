using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    // состояния растения
    public enum PlantState
    {
        Blooming,  // цветущее
        Healthy,   // нормальное
        Wilting,   // увядшее
        Dead       // мёртвое
    }
    public class Plant
    {
        // параметры растения
        public double Moisture { get; private set; } // влажность
        public double Nutrition { get; private set; } // питание
        public double Light { get; private set; } // свет

        // время последнего обновления состояния
        public DateTime LastUpdate { get; private set; }

        // конструктор: новое здоровое растение
        public Plant()
        {
            Moisture = 100;
            Nutrition = 100;
            Light = 100;
            LastUpdate = DateTime.Now;
        }

        // конструктор для загрузки из сохранённого состояния
        public Plant(double moisture, double nutrition, double light, DateTime lastUpdate)
        {
            Moisture = Math.Max(0, Math.Min(100, moisture));
            Nutrition = Math.Max(0, Math.Min(100, nutrition));
            Light = Math.Max(0, Math.Min(100, light));
            LastUpdate = lastUpdate;
        }

        // функция изменения параметров за прошедшее время (в минутах)
        public void ApplyDecay(double minutesPassed)
        {
            Moisture = Math.Max(0, Moisture - 0.5 * minutesPassed);
            Nutrition = Math.Max(0, Nutrition - 0.25 * minutesPassed);
            Light = Math.Max(0, Light - 0.35 * minutesPassed);
            LastUpdate = DateTime.Now;
        }

        // действия пользователя
        public void Water() => Moisture = Math.Min(100, Moisture + 20);
        public void Feed() => Nutrition = Math.Min(100, Nutrition + 20);
        public void GiveLight() => Light = Math.Min(100, Light + 20);

        // определяет текущее состояние для визуализации
        public PlantState GetVisualState()
        {
            var min = Math.Min(Moisture, Math.Min(Nutrition, Light));
            if (min >= 70) return PlantState.Blooming;
            if (min >= 30) return PlantState.Healthy;
            if (min >= 10) return PlantState.Wilting;
            return PlantState.Dead;
        }

        // нужно для обновления прогресс баров
        public (int moisture, int nutrition, int light) GetProgressValues()
        {
            return ((int)Moisture, (int)Nutrition, (int)Light);
        }
    }
}

