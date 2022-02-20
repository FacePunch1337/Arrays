using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dictionary
{
    internal class Program
    {
        private static Dictionary<String, String> dict;
        private static Dictionary<String, String>.KeyCollection dictKeys;
        private static String engWord;
        private static String ruWord;



        static void Main(string[] args)
        {
            while (true)
            {
               dict = new Dictionary<String, String>();

                Dictionary<String, String>.KeyCollection dictKeys = dict.Keys;

                Console.WriteLine("Словарь");
                Console.WriteLine("1] Добавить перевод");
                Console.WriteLine("2] Найти перевод");
                Console.WriteLine("3] Посмотреть словарь");
                
                
                var keyPressed = Console.ReadKey(true);
                //dict.Add("hello", "привет");
                while (keyPressed.KeyChar != '0')
                {
                    if (keyPressed.KeyChar == '1')
                    {
                        Console.WriteLine("Введите eng");
                        var eng = Console.ReadLine();

                        Console.WriteLine("Введите ru");
                        var ru = Console.ReadLine();

                        if (eng != "\0" || ru != "\0")
                        {
                            Console.WriteLine("Готово!");
                        }
                        dict.Add(eng, ru);

                    }

                    if (keyPressed.KeyChar == '2')
                    {
                        Console.Write("en: ");
                         engWord = Console.ReadLine();
                         ruWord = null;

                        try { ruWord = dict[engWord]; }
                        catch { ruWord = "Not Found"; }

                        
                        Console.WriteLine($"ru: {dict[engWord]}");

                    }

                    if (keyPressed.KeyChar == '3')
                    {

                        foreach (var item in dict)
                        {

                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                        

                        Console.WriteLine();


                    }
                    

               
                    keyPressed = Console.ReadKey(true);
                }
            }
        }
    }
}
