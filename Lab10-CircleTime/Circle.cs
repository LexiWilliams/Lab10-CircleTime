using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_CircleTime
{
    class Circle
    {
        #region Fields
        private double radius;
        #endregion

        #region Properties
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        #endregion

        #region Constructors
        public Circle()
        {

        }
        public Circle(double _radius)
        {
            radius = _radius;
        }
        #endregion

        #region Methods
        public double CalculateCircumference()
        {
            return (2 * Math.PI * Radius);
        }
        public string CalculateFormattedCircumference()
        {
           return FormatNumber(CalculateCircumference());
        }
        public double CalculateArea()
        {
            return (Math.PI * (Math.Pow(radius, 2)));
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber((CalculateArea()));
            
        }
        private string FormatNumber(double number)
        {
           return Math.Round(number, 2).ToString();
        }
        #endregion
    }
}
