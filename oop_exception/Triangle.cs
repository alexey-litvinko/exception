using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exception
{
    [ClassInfo("Создание треугольника")]
    class Triangle : Polygon
    {
        public Triangle(double Ax, double Ay, double Bx, double By, double Cx, double Cy) : base(Ax, Ay, Bx, By, Cx, Cy)
        {
                double AC = Math.Sqrt(Math.Pow((Cx - Ax), 2) + Math.Pow((Cy - Ay), 2));
                double AB = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2));
                double BC = Math.Sqrt(Math.Pow((Bx - Cx), 2) + Math.Pow((Cy - By), 2));               
                if (((AC + AB) > BC) & ((AC + BC) > AB) & ((BC + AB) > AC))
                {                    
                    Console.WriteLine("Создан треугольник с вершинами А[" + Ax + "," + Ay + "], B[" + Bx + "," + By + "], C[" + Cx + "," + Cy + "]");
                }
                else
                {
                    throw new Exception("Треугольник с вершинами А[" + Ax + "," + Ay + "], B[" + Bx + "," + By + "], C[" + Cx + "," + Cy + "]" + " не существует!");
                }           
            }      
        public override double Area()
        {
            Console.WriteLine("Класс треугольник: расчет площади");
            return 0;
        }
        public override double Perimeter()
        {
            Console.WriteLine("Класс треугольник: расчет периметра");
            return 0;
        }
        public string TypeOfTriangle()
        {
            Console.WriteLine("Определение типа треугольника");
            return "type";
        }
    }
}
