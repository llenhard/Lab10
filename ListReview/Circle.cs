using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListReview
{
    class Circle
    {
        private double _Radius;

        public Circle(double radius)
        {
            _Radius = radius;
        }

        public double CalculatedCircumference()
        {
            return 2 * Math.PI * _Radius;
        }

        public double CalculateArea()
        {
            return Math.PI * _Radius * _Radius;
        }

        public string CalcualteFormattedCircumference()
        {
            return Math.Round(CalculatedCircumference(), 2).ToString();
        }

        public string CalcualteFormattedArea()
        {
            return Math.Round(CalculateArea(), 2).ToString();
        }
    }
}
