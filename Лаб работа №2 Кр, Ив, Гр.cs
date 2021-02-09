using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kropotova_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // команда Console.Write выводит текст в консоль
            //Console.Write("Input katet1: ");
            /* Нахождениме площади прямоугольного треугольника
            // команда Console.ReadLine читает СТРОКУ из консоли
            var Katet1 = Console.ReadLine();

            Console.Write("Input katet2: ");
            var Katet2 = Console.ReadLine();

            // команда Math.Sqrt - квадратный корень
            // Math.Pow - возведение в степень
            // Convert.ToDouble - преобразует строку в число
            var Gipotenuza = Math.Sqrt(Math.Pow(Convert.ToDouble(Katet1), 2) + Math.Pow(Convert.ToDouble(Katet2), 2));

            // выводим результат
            // знак $ перед строкой указывает, что внутри строки в фигурных скобках названия переменных
            // Console.WriteLine($"Gipotenuza = {Gipotenuza}");

            var Perimetr = Gipotenuza + Convert.ToDouble(Katet1) + Convert.ToDouble(Katet2);
            var Square = Convert.ToDouble(Katet1) * Convert.ToDouble(Katet2) / 2;


            
            */

            /**/
            // команда Console.Write выводит текст в консоль
            // Console.Write("Input R: ");
            // var R = Console.ReadLine();

            //Console.Write("Input P: ");
            //var P = Console.ReadLine();

            //Math.PI = 3.14;
            // команда Math.Sqrt - квадратный корень
            // Math.Pow - возведение в степень
            // Convert.ToDouble - преобразует строку в число
            // var C = 2 * PI* R
            // var Square = Math.PI* Math.Pow(Convert.ToDouble(R), 2);

            //  Console.WriteLine($"Square = {Square}");

            // Console.WriteLine("enter");
            //  Console.ReadLine();




            // подключены какие-то библиотеки


            {
                // команда Console.Write выводит текст в консоль
                Console.Write("Input Xa: ");
                var Xa = Console.ReadLine();
                Console.Write("Input Ya: ");
                var Ya = Console.ReadLine();
                Console.Write("Input Xb: ");
                var Xb = Console.ReadLine();
                Console.Write("Input Yb: ");
                var Yb = Console.ReadLine();
                Console.Write("Input Xc: ");
                var Xc = Console.ReadLine();
                Console.Write("Input Yc: ");
                var Yc = Console.ReadLine();

                var AB = Math.Sqrt(
                        Math.Pow(Convert.ToDouble(Xb) - Convert.ToDouble(Xa), 2) +
                        Math.Pow(Convert.ToDouble(Yb) - Convert.ToDouble(Ya), 2)
                );
                var BC = Math.Sqrt(
                        Math.Pow(Convert.ToDouble(Xc) - Convert.ToDouble(Xb), 2) +
                        Math.Pow(Convert.ToDouble(Yc) - Convert.ToDouble(Yb), 2)
                );
                var AC = Math.Sqrt(
                      Math.Pow(Convert.ToDouble(Xc) - Convert.ToDouble(Xa), 2) +
                      Math.Pow(Convert.ToDouble(Yc) - Convert.ToDouble(Ya), 2)
              );
                var Perimetr = Convert.ToDouble(AB) + Convert.ToDouble(BC) + Convert.ToDouble(AC);

                var PolyPerimetr = Convert.ToDouble(Perimetr) / 2;
                var ploshad = Math.Sqrt(
                    Convert.ToDouble(PolyPerimetr) * (Convert.ToDouble(PolyPerimetr) - Convert.ToDouble(AB)) *
                    (Convert.ToDouble(PolyPerimetr) - Convert.ToDouble(BC)) *
                    (Convert.ToDouble(PolyPerimetr) - Convert.ToDouble(AC))
                    );
                // выводим результат
                // знак $ перед строкой указывает, что внутри строки в фигурных скобках названия переменных
                Console.WriteLine($"Perimetr = {Perimetr}");
                Console.WriteLine($"ploshad = {ploshad}");
                // читаем строку, чтобы консольное окно сразу не закрылось
                Console.Write("Press ENTER to continue...");
                Console.ReadLine();
            }
        }
    }
}
