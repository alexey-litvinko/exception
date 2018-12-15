using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace oop_exception
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Trace("trace message");
            logger.Debug("debug message");
            logger.Info("info message");
            logger.Warn("warn message");
            logger.Error("error message");
            logger.Fatal("fatal message");
            List<Polygon> col = new List<Polygon>();
            try
            {
                Triangle triangle1 = new Triangle(0, 0, 1, 0, 2, 0);    // задаем несуществующий треугольник
                col.Add(triangle1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                logger.Debug(e.ToString());
            }            
            Parallelogram par1 = new Parallelogram(-1, 1, -3, 2, -2, 4, -4, 5);
            logger.Info(par1);
            Rhomb rhomb = new Rhomb(2, 2, 4, 3, 3, 4, 5, 5);           
            object[] att = Attribute.GetCustomAttributes(typeof(Triangle), false);
            foreach (ClassInfo o in att)
            Console.WriteLine("Значение атрибута для класса Triangle - " + o.Name); 
            col.Add(par1);
            col.Add(rhomb);
            col.Sort();           
            Console.WriteLine("Объекты отсортированы по возрастанию поля Ax");
            foreach (Polygon o in col)
            {
                Console.WriteLine(o + " " + o.Ax);
            }
            Console.ReadKey();
        }
    }
}
