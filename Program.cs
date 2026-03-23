using System;

namespace Variant4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> Объект 1: конструктор по умолчанию");
            StrelkovoeOrujie orujie1 = new StrelkovoeOrujie();
            orujie1.PrintInfo();

            orujie1.Nazvanie = "АК-74";
            orujie1.Kalibr = 5.45f;
            orujie1.Dalnost = 500.0;

            Console.WriteLine(">>> Объект 1 после установки значений через свойства:");
            orujie1.PrintInfo();

            Console.WriteLine(">>> Объект 2: конструктор с параметрами");
            StrelkovoeOrujie orujie2 = new StrelkovoeOrujie("СВД", 7.62f, 1300.0);
            orujie2.PrintInfo();

            Console.WriteLine(">>> Объект 3: конструктор копирования (копия объекта 2)");
            StrelkovoeOrujie orujie3 = new StrelkovoeOrujie(orujie2);
            orujie3.Nazvanie = "СВДС (модификация)";

            orujie3.PrintInfo();
            Console.WriteLine(">>> Попытка задать некорректные значения:");
            orujie1.Kalibr = -5.0f;
            orujie1.Dalnost = -100.0;

            Console.WriteLine("\nПрограмма завершена. Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}