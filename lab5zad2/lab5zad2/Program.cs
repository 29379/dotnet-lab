using System;

namespace lab5zad2
{
    internal class Program
    {

        public static int ReadNumber()
        {
            string number = "";
            int in_ascii = int.MinValue;

            do
            {
                in_ascii = Console.Read();
            } while (in_ascii == ' ' || in_ascii == '\t' || in_ascii == 'n');

            while (in_ascii != ' ' && in_ascii != '\t' && in_ascii != 'n' && in_ascii != '\r')
            {
                char digit = (char)in_ascii;
                number += digit;
                in_ascii = Console.Read();
            }

            return Convert.ToInt32(number);
        }

        public static void ReadInLoop(int n)
        {
            int highest = int.MinValue;
            int second_highest = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = ReadNumber();

                if (num > highest)
                {
                    second_highest = highest;
                    highest = num;
                }
                else if (num > second_highest && num < highest)
                {
                    second_highest = num;
                }
            }

            if (second_highest == highest || second_highest == int.MinValue)
            {
                Console.WriteLine("There is no viable solution");
            }
            else
            {
                Console.WriteLine("Highest value - " + highest.ToString() + "\nSecond highest value - " + second_highest.ToString());
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input n: ");
            string tmp = Console.ReadLine();
            int n = 5;
            if (!int.TryParse(tmp, out int value))
            {
                Console.WriteLine("The n value was not appropriate: it will be set to 5 by default");
                ReadInLoop(n);
            }
            else
            {
                n = int.Parse(tmp);
                if (n >= int.MinValue && n <= 1)
                {
                    Console.WriteLine("There is no viable solution");
                }
                else
                {
                    ReadInLoop(n);
                }
            }
        }
    }
}
/*
 Napisać aplikację konsolową, w której użytkownik podaje na początku liczbę n>=1, a 
następnie n liczb rozdzielonych białymi znakami (spacja/tabulacja/enter). Po 
wczytaniu ostatniej liczby wypisać drugą co do wartości największą wartość spośród 
tych n liczb. W zadaniu NIE WOLNO użyć tablic, ani żadnych innych kolekcji do 
pamiętania kolejnych liczb, tylko kilka zmiennych .
Przykładowo dla danych:
7
3 4 2 6 1 6
odpowiedź jest 4.
Gdy wszystkie wartości są równe wypisać „brak rozwiązania”
*/