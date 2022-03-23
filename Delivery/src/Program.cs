using System;
using System.Collections.Generic;
using System.IO;

namespace TAIO
{
    class Program
    {
        static void Main()
        {
            string[] files = Directory.GetFiles("./tests");
            foreach (var file in files)
            {
                using (StreamReader sr = File.OpenText(file))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        int[] numbers;
                        List<Element> list = new List<Element>();
                        string type = sr.ReadLine();
                        string content = sr.ReadLine();
                        int size = int.Parse(s);
                        if (int.TryParse(content, out int random))
                        {
                            int arraySize = size == 5 ? 18 : 35;
                            numbers = new int[arraySize];
                            Random r = new Random();
                            for (int i = 0; i < random; i++)
                                numbers[r.Next(arraySize)]++;
                        }
                        else
                        {
                            List<int> l = new List<int>();
                            string[] snumbers = content.Split(' ');
                            foreach (var n in snumbers)
                                if (int.TryParse(n, out int result))
                                    l.Add(result);
                            numbers = l.ToArray();
                        }
                        if (size == 5)
                            list = Functions.Element5Factory(numbers);
                        if (size == 6)
                            list = Functions.Element6Factory(numbers);
                        if (type == "op")
                            Functions.CalculateOP(list);
                        if (type == "hp")
                            Functions.CalculateHP(list);
                    }
                }
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Koniec programu. Naciśnij dowolny przycisk, aby kontynuować");
            Console.ReadKey();
        }
    }
}
