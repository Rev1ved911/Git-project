using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        const double Pi = 3.14159;

        static void Main(string[] args)
        {
            string Variant = "";
            while (Variant != "exit")
            {
                Console.Write("\nДлина и площадь круга - 1 \n" + "Периметр и площадь квадрата - 2 \n" + "Периметр и площадь треугольника - 3 \n" + "Выход - exit \n" + "Выберите вариант => ");
                Variant = Console.ReadLine();
                switch (Variant)
                {
                    case "1":
                        Console.WriteLine("\n Вычисление площади и длины окружности");
                        double Radius, SuperficieOkr, DlinaOkr;
                        Console.Write("\n   Введите радиус окружности => ");
                        Radius = Convert.ToDouble(Console.ReadLine());
                        SuperficieOkr = Pi * Math.Pow(Radius, 2);
                        DlinaOkr = 2 * Pi * Radius;
                        Console.WriteLine($"\n       При радиусе окружности {Radius}" + $"\n       Его площадь составляет {SuperficieOkr}, а длина {DlinaOkr}");
                        Console.Write("\n\n\n\n\n\n           Введите 'exit' для выхода, или нажмите <Enter> для возврата в меню" + "\n           Ввод => ");
                        Variant = Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("\n Вычисление площади и периметра квадрата");
                        double StoronaKv, SuperficieKv, PerimetrKv;
                        Console.Write("\n   Введите одну из стороно квадрата => ");
                        StoronaKv = Convert.ToDouble(Console.ReadLine());
                        SuperficieKv = Math.Pow(StoronaKv, 2);
                        PerimetrKv = StoronaKv * 4;
                        Console.WriteLine($"\n       При одной из сторон квадрата {StoronaKv}" + $"\n     Его площадь состовляет {SuperficieKv}, а периметр {PerimetrKv}");
                        Console.Write("\n\n\n\n\n\n           Введите 'exit' для выхода, или <Enter> для возврата в меню" + "\n           Ввод => ");
                        Variant = Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("\n Вычисление площади и периметра прямоугольного треугольника");
                        double SuperficieTr, KatetA, KatetB, PerimetrTr;
                        Console.Write("\n   Введите катет А => ");
                        KatetA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("   Введите катет В => ");
                        KatetB = Convert.ToDouble(Console.ReadLine());
                        SuperficieTr = 0.5 * KatetA * KatetB;
                        PerimetrTr = Math.Sqrt(Math.Pow(KatetA, 2) + Math.Pow(KatetB, 2)) + KatetA + KatetB;
                        Console.WriteLine($"\n       При катете А = {KatetA}, и катете B = {KatetB}" + $"\n     Площадь прямоугольного треугольника = {SuperficieTr}, а периметр = {PerimetrTr}");
                        Console.Write("\n\n\n\n\n\n           Введите 'exit' для выхода, или <Enter> для возврата в меню" + "\n           Ввод => ");
                        Variant = Console.ReadLine();
                        Console.Clear();
                        break;
                    case "exit":
                        return;
                    case "EXIT":
                        return;
                    case "Exit":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n Выбран не верный вариант. Попробуйте снова:");
                        break;
                }
            }
        }
    }
}
