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
            double x = 0,y=0;//переменные для координат
            VvodPoint("координата х", out x);//вводим координату х
            VvodPoint("координата у", out y);//вводим координату у
            if ((x * x + y * y <= 1) && (x * x + y * y >= 0.25)) Console.WriteLine("Точка принадлежит");//проверка принадлежности
                else Console.WriteLine("Точка не принадлежит");
            Console.ReadKey();                           
        }
        static double VvodPoint(string s, out double n)//Функция для ввода координат, с проверской на ввод
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
