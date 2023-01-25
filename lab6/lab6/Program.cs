using System;
using System.Xml.Linq;


namespace lab6
{
    class Program
    {

        static void Divide(int count) { 
            Console.Write("\n\n* * * * * * * * * * ZAD {0} * * * * * * * * * *\n\n", count);
        }

        static void Zad1() {
            var tuple = (Name: "Jakub", Surname: "Krupiński", Age: 22, Salary: 12345);
            WriteTupleToConsole(tuple);
        }

        static void Zad2()
        {
            int @class = 111;
            Console.WriteLine(@class);
        }

        static void Zad3()
        {
            //  Copy, IndexOf, LastIndexOf, Sort, Reverse
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 1, 8 };
            int[] arr2 = { 10, 11};

            Console.Write("arr1: ");
            foreach(var elem in arr1)
            {
                Console.Write("{0} - ", elem.ToString());
            }

            Console.Write("\narr2: ");
            foreach (var elem in arr2)
            {
                Console.Write("{0} - ", elem.ToString());
            }

            System.Array.Copy(arr1, arr2, 2);
          
            Console.Write("\narr2 after copying first 2 elements with System.Array.Copy:\n");
            foreach (var elem in arr2)
            {
                Console.Write("{0} - ", elem.ToString());
            }

            Console.WriteLine("\n\nFound the index of 7 in 'arr1': {0}",
                System.Array.IndexOf(arr1, 7));

            Console.WriteLine("\nFound the index of the last occurence of 1 in 'arr1': {0}",
                System.Array.LastIndexOf(arr1, 1));

            System.Array.Sort<int>(arr1,
                    new Comparison<int>(
                            (i1, i2) => i2.CompareTo(i1)
                    ));
            Console.WriteLine("\n'arr1' after sorting it in descending order:");
            foreach (var elem in arr1)
            {
                Console.Write("{0} - ", elem.ToString());
            }

            System.Array.Reverse(arr1, 3, 4);
            Console.WriteLine("\n\n'arr1' after reversing its order between indexes 3 and 6:");
            foreach (var elem in arr1)
            {
                Console.Write("{0} - ", elem.ToString());
            }
        }

        static void Zad4() {
            var tuple = new { Name= "Jakub", Surname = "Krupiński", Age = 22, Salary = 12345};
            WriteDynamicToConsole(tuple);
        }

        static void Zad5() {
            DrawCard("Kuba");
            Console.WriteLine("\n");
            DrawCard("Kuba", separator: '?');
            Console.WriteLine("\n");
            DrawCard("Kuba", frame_size: 5);
            Console.WriteLine("\n");
            DrawCard("Kuba", frame_size: 3, card_min_size: 6);
            Console.WriteLine("\n");
            DrawCard("Kuba", surname: "Krupiński", frame_size: 10, card_min_size: 8, separator: '*');
            Console.WriteLine("\n");
        }

        static void Zad6() {
            (int evenIntegersCount, int positiveDoublesCount, int stringsLongerThan4Count, int differentTypesCount) tuple = 
                CountMyTypes(1, 3, 2, -1.3, "aaa", "aaaaaa", "a", "aaaaaaaa", 44, 44.44, true, false, '?');
            Console.WriteLine($"Results:\n\t- even integers: {tuple.evenIntegersCount}\n\t" +
                $"- positive doubles: {tuple.positiveDoublesCount}\n\t" +
                $"- strings longer than 4: {tuple.stringsLongerThan4Count}\n\t" +
                $"- different types: {tuple.differentTypesCount}");
        }

        static void Lab6()
        {
            int i = 0;
            Divide(++i);
            Zad1();
            Divide(++i);
            Zad2();
            Divide(++i);
            Zad3();
            Divide(++i);
            Zad4();
            Divide(++i);
            Zad5();
            Divide(++i);
            Zad6();
        }

        static void WriteTupleToConsole((string Name, string Surname, int Age, int Salary) tuple)
        {
            (string name, string surname, int age, int salary) = tuple;
            Console.WriteLine("- Tuple after unpacking it into separately declared variables\n" +
                "  Imie: {0}, nazwisko: {1}, wiek: {2}, płaca: {3}", name, surname, age, salary);

            string name1, surname1;
            int age1, salary1;
            (name1, surname1, age1, salary1) = tuple;
            Console.WriteLine("- Tuple after unpacking it into already declared (separately) variables\n" +
                "  Imie: {0}, nazwisko: {1}, wiek: {2}, płaca: {3}", name1, surname1, age1, salary1);


            Console.WriteLine("- Tuple after accessing its content from Item1/2/3/4-attribiutes\n" +
                $"  Imie: {tuple.Item1}, nazwisko: {tuple.Item2}, wiek: {tuple.Item3}, płaca: {tuple.Item4}");
        }

        static void WriteDynamicToConsole(dynamic tuple)
        {
            Console.WriteLine("- Tuple after accessing its content via names while passing it dynamically to a method\n" +
                $"  Imie: {tuple.Name}, nazwisko: {tuple.Surname}, wiek: {tuple.Age}, płaca: {tuple.Salary}");
        }

        static void DrawCard(string name, string surname="N/A", char separator='0', int frame_size=2, int card_min_size=16)
        {
            int name_lines_number = 2;
            if (frame_size < 0)
            {
                frame_size = 2;
            }
            int card_width = card_min_size;
            int extra = 2;
            int name_length = name.Length + extra + 2 * frame_size;

            //  adjust the sizes
            if (name_length > card_width)
            {
                card_width = name_length;
            }
            int surname_length = surname.Length + extra + 2 * frame_size;
            if (surname_length > card_width)
            {
                card_width = surname_length;
            }
            
            //  create the card template
            char[][] arr_2d = new char[name_lines_number + 2 * frame_size][];
            char[] frame = new char[card_width];
            Array.Fill(frame, separator);

            //  clear the space in the middle for name and surname
            char[] l1 = new char[card_width];
            char[] l2 = new char[card_width];
            Array.Fill(l1, ' ');
            Array.Fill(l2, ' ');
            arr_2d[frame_size] = l1;
            arr_2d[frame_size + 1] = l2;

            
            for (int i = 0; i < frame_size; i++)
            {
                arr_2d[i] = frame;
                arr_2d[arr_2d.Length - 1 - i] = frame;

                l1[i] = separator;
                l1[card_width - 1 - i] = separator;
                l2[i] = separator;
                l2[card_width - 1 - i] = separator;
            }

            //  write the name and surname
            (int begin_name, int begin_surname) indexes = (
                (int)(card_width / 2 - name.Length / 2),
                (int)(card_width / 2 - surname.Length / 2));
            for (int i = 0; i < name.Length; i++)
            {
                l1[i + indexes.begin_name] = name[i];
            }
            for (int i = 0; i < surname.Length; i++)
            {
                l2[i + indexes.begin_surname] = surname[i];
            }

            //  print the whole thing
            foreach (char[] line in arr_2d)
            {
                Console.WriteLine(String.Join("", line));
            }
        }

        static (int evenIntegersCount, int positiveDoublesCount, int stringsLongerThan4Count, int differentTypesCount) CountMyTypes(params dynamic[] arr)
        {
            (int evenIntegersCount, int positiveDoublesCount, int stringsLongerThan4Count, int differentTypesCount) tuple = (0, 0, 0, 0);

            foreach(dynamic elem in arr)
            {
                switch (elem)
                {
                    case int i when i % 2 == 0:
                        tuple.evenIntegersCount += 1;
                        break;
                    case double d when d >= 0:
                        tuple.positiveDoublesCount += 1;
                        break;
                    case string s when s.Length > 4:
                        tuple.stringsLongerThan4Count += 1;
                        break;
                    default:
                        tuple.differentTypesCount += 1;
                        break;
                }
            }

            return tuple;
        }

        static void Main(string[] args)
        {
            Lab6();
        }
    }
}
