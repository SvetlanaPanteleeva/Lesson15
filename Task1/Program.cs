using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия:");
            ArithProgression arith = new ArithProgression();
            Console.WriteLine("Стартовое значение 5, шаг 3");
            arith.SetStart(5);
            arith.SetStep(3);
            Console.WriteLine("Вывод первого значения:");
            Console.WriteLine(arith.GetNext());
            Console.WriteLine("Вывод второго значения:");
            Console.WriteLine(arith.GetNext());
            Console.WriteLine("Вывод третьего значения:");
            Console.WriteLine(arith.GetNext());
            Console.WriteLine("Сброс");
            arith.Reset();
            Console.WriteLine("Вывод первого значения:");
            Console.WriteLine(arith.GetNext());
            Console.WriteLine("Вывод второго значения:");
            Console.WriteLine(arith.GetNext());
            Console.WriteLine("Геометрическая прогрессия:");
            GeomProgression geom = new GeomProgression();
            Console.WriteLine("Стартовое значение 5, шаг 2");
            geom.SetStart(5);
            geom.SetStep(2);
            Console.WriteLine("Вывод первого значения:");
            Console.WriteLine(geom.GetNext());
            Console.WriteLine("Вывод второго значения:");
            Console.WriteLine(geom.GetNext());
            Console.WriteLine("Вывод третьего значения:");
            Console.WriteLine(geom.GetNext());
            Console.WriteLine("Сброс");
            geom.Reset();
            Console.WriteLine("Вывод первого значения:");
            Console.WriteLine(geom.GetNext());
            Console.WriteLine("Вывод второго значения:");
            Console.WriteLine(geom.GetNext());
            Console.ReadKey();
        }
    }
}
