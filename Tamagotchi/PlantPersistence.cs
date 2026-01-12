using System.Text.Json;
using System.IO;

namespace Tamagotchi
{
    public class PlantPersistence
    {
        private readonly string _filePath;

        public PlantPersistence(string? customPath = null)
        {
            _filePath = customPath ?? Path.Combine(
                Application.UserAppDataPath,
                "plant_state.json"
            );
        }

        public Plant? Load()
        {
            if (!File.Exists(_filePath))
                return null;

            try
            {
                var json = File.ReadAllText(_filePath);
                var data = JsonSerializer.Deserialize<PlantStateData>(json);
                if (data != null)
                {
                    return new Plant(data.Moisture, data.Nutrition, data.Light, data.LastUpdate);
                }
            }
            catch
            {
            }

            return null;
        }

        public void Save(Plant plant)
        {
            try
            {
                var data = new PlantStateData
                {
                    Moisture = plant.Moisture,
                    Nutrition = plant.Nutrition,
                    Light = plant.Light,
                    LastUpdate = plant.LastUpdate
                };

                var folder = Path.GetDirectoryName(_filePath)!;
                Directory.CreateDirectory(folder);

                var options = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(data, options);
                File.WriteAllText(_filePath, json);
            }
            catch
            {
            }
        }
    }
}