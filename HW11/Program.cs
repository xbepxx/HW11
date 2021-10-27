using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение линейного уравнения aх+b=0");
            Console.WriteLine("Введите значения a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значения b");
            double b = Convert.ToDouble(Console.ReadLine());
            root root = new root(a, b);
            root.Root();
            Console.ReadKey();
        }
        struct root
        {
            public double a;
            public double b;
            public double x;
            public root(double a, double b) : this()
            {
                this.a = a;
                this.b = b;
            }
            public void Root()
            {
                if (a != 0)
                {
                    x = -b / a;
                }
                else
                {
                    Console.WriteLine("Введите значение a, отличное от 0");
                }
                Console.WriteLine("Значение х равно: {0}", x);
                //Console.ReadKey();
            }

        }
    }
}
