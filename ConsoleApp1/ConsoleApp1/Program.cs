using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            /*
            Write("введите год:");
            int year = int.Parse(ReadLine());
            if (year % 4 == 0)
            {
                WriteLine("год високосный");
            }
            else
            {
                WriteLine("год не високосный");
            }
            */
            /*
            Write("введите цену ноутбука: ");
            int price = int.Parse(ReadLine());
            if (price >= 20000 && price <= 30000)
            {
                WriteLine("ноутбук входит в ценовую категорию от 20000 до 30000");
            }
            else
            {

                WriteLine("ноутбук не входит в ценовую категорию от 20000 до 30000");

            }
            */
            //3
            /*
            Write("введите кол-во баллов(от 0 до 100: ");
            byte points = byte.Parse(Console.ReadLine());
            if (points <= 60)
            {
                WriteLine("неудовлетворительно");
            }
            else if (points > 60 && points <= 74)
            {
                WriteLine("удовлетворительно");
            
            }
            else if (points >= 75 && points <= 89)
            {
                WriteLine("хорошо");

            }
            else if (points >= 90 && points <= 100)
            {
                WriteLine("отлично");

            }*/
            //4
            /*
            WriteLine("какое состояние светофора?(1-3): ");
            byte svet = byte.Parse(Console.ReadLine());
            if (svet == 1)
            {
                WriteLine("зеленый");
            }
            else if(svet == 2)
            {
                WriteLine("желтый");
            }
            else if (svet == 3)
            {
                WriteLine("красный");
            }
            else if (svet == 0 || svet < 4)
            {
                WriteLine("это уже не светофор...");
            }
            */
            /*
            Random rnd = new Random();
            int randomnoe_chislo = rnd.Next(-1000,1000);
            if (randomnoe_chislo % 2 == 0)
            {
                WriteLine($"{randomnoe_chislo} четное");
            }
            else 
            {
                WriteLine($"{randomnoe_chislo} нечетное");

            }
            */
            //проверка логина и пароля, сделана была еще на 1 курсе :3
            /*
            string idealLog = "asdasd";
            int log2 = idealLog.Length;
            string idealPass = "asdasdas";
            int pas2 = idealPass.Length;
            Write("Придумайте свой логин. (Не менее 6 символов)");
            string myLog = ReadLine();
            int log = myLog.Length;
        M1:
            Write("Введите пароль. (Не менее 8 символов)");
            string MyPas = ReadLine();
            int pas = MyPas.Length;
            Clear();
            if (log >= log2)
            {
                WriteLine("ваш логин соотвествует нашим требованиям.");
            }
            else
            {
                WriteLine("ваш логин не соотвествует нашим требованиям. Попробуйте снова");
                goto M;
            }
            if (pas >= pas2)
            {
                WriteLine("ваш пароль соотвествует нашим требованиям.");
            }
            else
            {
                WriteLine("ваш пароль не соотвествует нашим требованиям. перезапустите программу");
                goto M1;
            }
            */
            /*
            double result = 0;
            

            Write("Введите первое число: ");
            double num1 = Convert.ToDouble(ReadLine());

            Write("Введите оператор (+, -, *, /): ");
            char op = Convert.ToChar(ReadLine());

            Write("Введите второе число: ");
            double num2 = Convert.ToDouble(ReadLine());

            if (op == '+')
            {
                result = num1 + num2;
            }
            else if (op == '-')
            {
                result = num1 - num2;
            }
            else if (op == '*')
            {
                result = num1 * num2;
            }
            else if (op == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    WriteLine("на ноль делить нелья");
                    return;
                }
            }
           WriteLine("Результат: " + result);
        */
   
            
    ReadKey();

        }
    }
}
