using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class PlantStateData
    {
        public double Moisture { get; set; }
        public double Nutrition { get; set; }
        public double Light { get; set; }
        public DateTime LastUpdate { get; set; }
        public string? PlantName { get; set; }
    }
}
