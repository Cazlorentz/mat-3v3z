using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    interface iLineærRegression
    {
        public List<Double> x_points { get; set; }
        public List<Double> y_points { get; set; }
        public string Function { get; set; }
        public double Average_x { get; set; }
        public double Average_y { get; set; }
        public double Sakx { get; set; } 
        public double Saky { get; set; }
        public double Sapxy { get; set; }
        public double Slope { get; set; }
        public double Intersect { get; set; }
        public double R_squared { get; set; }
        public double RKS { get; set; }
        public double Average();
        public double Sak_Of_Regression();
        public double Sapxy_Calc();
        public double RKS_Calc();
    }
}
