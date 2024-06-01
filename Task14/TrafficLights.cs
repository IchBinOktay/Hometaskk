using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    internal class TrafficLights
    {
        public Color LightColor { get; set; }


        public TrafficLights(Color color)
        {
            LightColor = color;
        }

        internal enum Color
        {
            Red,
            Yellow,
            Green
        }

        public void ChangeColor()
        {
            switch (LightColor)
            {
                case Color.Red:
                    LightColor = Color.Green;
                    break;
                case Color.Green:
                    LightColor = Color.Yellow;
                    break;
                case Color.Yellow:
                    LightColor = Color.Red;
                    break;
            }
        }
        public Color GetCurrentColor()
        {
            return LightColor;
        }
    }
}
