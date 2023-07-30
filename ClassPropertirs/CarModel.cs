using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPropertirs
{
    class CarModel
    {
        List<string> lsColor = new List<string>() { "blue", "red", "yellow" };

        public string Name;
        public string ManuFacturer;
        public string color;
         
        public CarModel(string name, string manufacturer, string color)
        {
            Name = name;
            ManuFacturer = manufacturer;
            Color = color;
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (lsColor.Contains(value))
                {
                    color = value;
                }
                else
                    color = "ND";
            }
        }
    }
}
