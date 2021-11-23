using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Foundation.Prototype
{
    public class Implementation
    {
        static void Main(string[] args)
        {
            ColorManager colorManager = new ColorManager();
            colorManager["red"] = new Color(255, 0, 0);
            colorManager["green"] = new Color(0, 255, 0);
            colorManager["blue"] = new Color(0, 0, 255);
            colorManager["angry"] = new Color(255, 54, 0);

            Color color1 = colorManager["red"].Clone() as Color;
            Color color2 = colorManager["green"].Clone() as Color;
            Color color3 = colorManager["angry"].Clone() as Color;

            Console.ReadKey();
        }
    }
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class Color : Prototype
    {
        int red;
        int green;
        int blue;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override Prototype Clone()
        {
            Console.WriteLine($"Cloning color RGB: {red}, {green},{blue}");
            return this.MemberwiseClone() as Prototype;
        }
    }

    public class ColorManager
    {
        private Dictionary<string, Prototype> colors = new Dictionary<string, Prototype>();
        public Prototype this[string key]
        {
            get { return colors[key]; }
            set { colors.Add(key, value); }
        }
    }
}
