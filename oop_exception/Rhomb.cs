using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exception
{
    [ClassInfo("Создание ромба")]
    class Rhomb : Parallelogram
    {
        public Rhomb(double Ax, double Ay, double Bx, double By, double Cx, double Cy, double Dx, double Dy) : base(Ax, Ay, Bx, By, Cx, Cy, Dx, Dy)
        {
            Console.WriteLine("Этот параллелограмм является ромбом");
        }
        public double InRadius()
        {
            Console.WriteLine("Расчет радиуса вписанной окружности");
            return 0;
        }
    }
}
