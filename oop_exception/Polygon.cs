using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exception
{
    [ClassInfo("Создание многоугольника")]
    abstract class Polygon : IComparable<Polygon>
    {
        public double Ax, Ay, Bx, By, Cx, Cy;
        public Polygon(double Ax, double Ay, double Bx, double By, double Cx, double Cy)
        {            
            this.Ax = Ax;
            this.Ay = Ay;
            this.Bx = Bx;
            this.By = By;
            this.Cx = Cx;
            this.Cy = Cy;
        }
        public abstract double Area();
        public abstract double Perimeter();
        public int CompareTo(Polygon obj)
        {
            if (Ax > obj.Ax)
                return 1;
            if (Ax < obj.Ax)
                return -1;
            else
                return 0;
        }
    }
}