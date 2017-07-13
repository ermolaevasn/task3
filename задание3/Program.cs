using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0,y=0;
            VvodPoint("координата х", out x);
            VvodPoint("координата у", out y);
            if ((x * x + y * y <= 1) && (x * x + y * y >= 0.25)) Console.WriteLine("Точка принадлежит");
                else Console.WriteLine("Точка не принадлежит");
            Console.ReadKey();                           
        }
        static double VvodPoint(string s, out double n)//Вввод размера массива
        {
            bool ok;
            string buf;
            do
            {
                Console.Write(s + " = ");
                buf = Console.ReadLine();
                ok = double.TryParse(buf, out n);
                if (!ok) Console.WriteLine("Введите " + s + " заново");
            } while (!ok);
            return n;
        }
    }
}
