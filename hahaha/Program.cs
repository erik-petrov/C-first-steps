using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;
//void - ничего не запоминает
namespace hahaha
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = new string[7] { "a", "b", "c", "d", "e", "f", "g" };
            foreach (string i in words)
            {
                Console.WriteLine(i);
            }

            for (int i = words.Length; i < 0; i--)
            {
                Console.WriteLine(words[i]);
            }

            ConsoleKeyInfo key = new ConsoleKeyInfo();

            do
            {
                Console.WriteLine("Press Escape");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);

            /*string name;
            int num;
            Console.OutputEncoding = Encoding.UTF8;
            Random rnd = new Random();
            Console.WriteLine("Хочешь ли ты рандомный день?: ");
            string dec = Console.ReadLine();
            if (dec == "da")
            {
                num = rnd.Next(1, 8);
            }
            else if(dec == "net")
            {
                Console.WriteLine("Впиши день");
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    num = 0;
                }
            }
            else
            {
                Console.WriteLine("По аккуратнее с языком молодой человек.");
                num = 1;
            }
            
            Console.WriteLine("День {0}",num.ToString());
            Console.WriteLine($"День {num}");
            switch (num)
            {
                case 1: name = "Monday"; break;
                case 2: name = "Tuesday"; break;
                case 3: name = "Wednesday"; break;
                case 4: name = "Thursday"; break;
                case 5: name = "Friday"; break;
                case 6: name = "Saturday"; break;
                case 7: name = "Sunday"; break;
                default:
                    name = "haha";
                    break;
            }
            Console.WriteLine(name);

            //  ..\..\ = выше на 2 папки

            StreamWriter f = new StreamWriter(@"..\..\..\file.txt",true);
            f.WriteLine($"The chosen day was: {name}, the number was {num}");
            f.Close();*/

            //задание 1

            /*Random rnd = new Random();
            Console.OutputEncoding = Encoding.UTF8;

            double a = rnd.Next(1, 50);
            double b = rnd.Next(1, 50);
            double c;
            c = (2 * a + b) / (11 * a - 13 * b);
            Console.WriteLine($"Значения были: a - {a} b - {b}\nРешение: {c}");

            StreamWriter f = new StreamWriter(@"..\..\..\math.txt", true);
            f.WriteLine($"Значения были: a - {a} b - {b}\nРешение: {c}");
            f.Close();
            StreamReader r = new StreamReader(@"..\..\..\math.txt");
            string from = r.ReadToEnd();
            Console.WriteLine($"\nThe file contains: \n{from}");
            r.Close();*/

            //тут начинаетс задание 2

            /*string fio, group, number, age, sex, labNum, nameLab;

            Console.WriteLine("Введите свое: \nФИО");
            fio = Console.ReadLine();
            Console.WriteLine("Теперь группу: ");
            group = Console.ReadLine();
            Console.WriteLine("Теперь номер варианта: ");
            number = Console.ReadLine();
            Console.WriteLine("Теперь возраст: ");
            age = Console.ReadLine();
            Console.WriteLine("Теперь пол: ");
            sex = Console.ReadLine();
            Console.WriteLine("Теперь номер лаб. работы: ");
            labNum = Console.ReadLine();
            Console.WriteLine("Теперь название лаб. работы: ");
            nameLab = Console.ReadLine();
            StreamWriter file = new StreamWriter(@"..\..\..\info.txt", false, Encoding.UTF8);
            file.WriteLine($"Вот наша информация о вас: \nФИО: {fio}\nГруппа: {group} \nНомер варианта: {number}\nВозраст: {age}\nПол: {sex}\nНомер лаб. работы: {labNum}\nНазвание лаб. работы: {nameLab}");
            file.Close();*/

            //Здесб начинается лаб 14

            /*double first, second;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первую переменную: ");
                    first = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("и вторую: ");
                    second = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ты совершил ошибку, повтори ввод. Заметь, что переменные должны быть цифрами.");
                }
            }
            
            if (first + second >= 0)
            {
                Console.WriteLine("Сумма этих чисел положительная.");
            }
            else
            {
                Console.WriteLine("Сумма этих чисел отрицательная.");
            }*/
        }
    }
}
