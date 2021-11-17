using System;
using System.Collections.Generic;

namespace Rozgrzewka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.WriteLine("----------------------");
            int result = 5 + 9;
            Console.WriteLine(result);

            Console.WriteLine("----------------------");
            int number = 1;
            float money = 2.1F;
            string text = "EZE";
            bool isLogged = false;
            char myChar = '+';
            decimal price = 9.999999999999999999M;
            Console.WriteLine(number);
            Console.WriteLine(money);
            Console.WriteLine(text);
            Console.WriteLine(isLogged);
            Console.WriteLine(myChar);
            Console.WriteLine(price);

            Console.WriteLine("----------------------");
            string myAge = "Age: ";
            int wifeAge = 18;
            string resultv2 = myAge + wifeAge;
            Console.WriteLine(resultv2);

            Console.WriteLine("----------------------");
            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;
            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;
            Console.WriteLine(and);
            Console.WriteLine(or);
            Console.WriteLine(negative);

            Console.WriteLine("----------------------");
            int a = 5;
            int b = 12;
            int add = a + b;
            int sub = b - a;
            decimal div = (decimal)b / a;
            int mul = a * b;
            decimal mod = a % b;
            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mul);
            Console.WriteLine(mod);
            
            Console.WriteLine("----------------------");
            string av2 = "Ala ";
            string bv2 = "ma ";
            string c = "kota. ";
            string resultv3 = av2 + bv2 + c;
            Console.WriteLine(resultv3);
            //Wyświetliło normalne zdanie piękne nawet ze psacjami i kropeczką <3

            Console.WriteLine("----------------------");
            int n1 = 10;
            int n2 = 20;

            if (n1 == n2)
            {
                Console.WriteLine("n1 jest równe n2");
            }
            else if (n1>n2)
            {
                Console.WriteLine("n1 jest większe od n2");
            }
            else
            {
                Console.WriteLine("n1 jest mniejsze od n2");
            }

            Console.WriteLine("----------------------");
            int x = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C#");
            }
            Console.WriteLine("To był if a teraz while");
            while (x<10)
            {
                Console.WriteLine("C#");
                x++;
            }
            Console.WriteLine("----------------------");
            int n = 10;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " :Parzysta");
                }
                else
                {
                    Console.WriteLine(i + " :Nieparzysta");
                }
            }
            Console.WriteLine("----------------------");
            int nv3 = 5;
            for (int i = 0; i < nv3; i++)
            {
                string sak = "";
                for (int j = 0; j < nv3; j++)
                {
                    if (i >= j)
                        sak += "*";
                }
                Console.WriteLine(sak);

            }

            Console.WriteLine("----------------------");
            string[] colors = new string[4];
            colors[0] = "różowy";
            colors[1] = "biały";
            colors[2] = "czarny";
            colors[3] = "żółty";

            Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
            Console.WriteLine("Mój ostatni kolor to: " + colors[3]);
            
            Console.WriteLine("----------------------");
            int[] liczby = new int[10];
            liczby[0] = 1;
            liczby[1] = 44;
            liczby[2] = 6;
            liczby[3] = 65;
            liczby[4] = 99;
            liczby[5] = 111;
            liczby[6] = 112;
            liczby[7] = 333;
            liczby[8] = 22;
            liczby[9] = 0; //dokończyc!!!

            Console.WriteLine("----------------------");
            List<string> fruits = new List<string>();
            fruits.Add("liczi");
            fruits.Add("jabłko");
            fruits.Add("gruszka");
            fruits.Add("pomidor");
            Console.WriteLine(fruits[0] + ", " + fruits[1] + ", " + fruits[2] + ", " + fruits[3]);
            fruits.Remove("liczi");
            fruits.RemoveAt(2);
            foreach (string fruit in fruits)
            {
                Console.Write($"{fruit},");
            }
        }
    }
}
