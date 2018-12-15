using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exception
{
    [ClassInfo("Создание параллелограмма")]
    class Parallelogram : Polygon
    {
        double Dx, Dy;
        public Parallelogram(double Ax, double Ay, double Bx, double By, double Cx, double Cy, double Dx, double Dy) : base(Ax, Ay, Bx, By, Cx, Cy)
        {
            this.Dx = Dx;
            this.Dy = Dy;
            Console.WriteLine("Создан параллелограмм с вершинами А[" + Ax + "," + Ay + "], B[" + Bx + "," + By + "], C[" + Cx + "," + Cy + "], D[" + Dx + "," + Dy + "]");
        }
        public override double Area()
        {
            Console.WriteLine("Класс параллелограмм: расчет площади");
            return 0;
        }
        public override double Perimeter()
        {
            Console.WriteLine("Класс параллелограмм: расчет периметра");
            return 0;
        }
        public double Heigth()
        {
            Console.WriteLine("Класс параллелограмм: расчет высоты");
            return 0;
        }
    }
}