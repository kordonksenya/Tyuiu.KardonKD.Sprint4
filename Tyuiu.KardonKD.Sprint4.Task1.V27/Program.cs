using Tyuiu.KardonKD.Sprint4.Task1.V27.Lib;
namespace Tyuiu.KardonKD.Sprint4.Task1.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Кордон К.Д. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Кордон Ксения Дмитриевна | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[] { 8, 1, 4, 4, 1, 2, 3, 5, 1, 5 };

            Console.WriteLine("Массив = 8, 1, 4, 4, 1, 2, 3, 5, 1, 5");

            int s = ds.Calculate(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
