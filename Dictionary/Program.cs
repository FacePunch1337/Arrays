using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dictionary
{
    internal class Program
    {
        private static Dictionary<String, String>dict;
      
 
        static void Main(string[] args)
        {
            while (true)
            {
                dict = new Dictionary<String, String>();
                dict.Add("hello", "привет");
                dict.Add("bye", "пока");
                dict.Add("hi", "добрый день");

                Console.WriteLine("Словарь");
                Console.WriteLine("1] Найти перевод [en]");
                Console.WriteLine("2] Найти перевод [ru]");
                Console.WriteLine("3] Добавить перевод");
                Console.WriteLine("4] ");

                var keyPressed = Console.ReadKey(true);
                while (keyPressed.KeyChar != '0')
                {
                    if (keyPressed.KeyChar == '1')
                    {
                        Console.Write("en: ");
                        String enWord = Console.ReadLine();
                        String ruWord = null;

                        try { ruWord = dict[enWord]; }
                        catch { ruWord = "Not Found"; }

                        Console.WriteLine(dict[enWord]);

                    }

                    if (keyPressed.KeyChar == '2')
                    {
                        Console.Write("en: ");
                        String enWord = Console.ReadLine();
                        String ruWord = null;

                        try { ruWord = dict[enWord]; }
                        catch { ruWord = "Not Found"; }

                        Console.WriteLine(dict[enWord]);

                    }
                    if (keyPressed.KeyChar == '3')
                    {
                        var en = Console.ReadLine();
                        var ru = Console.ReadLine();
                        dict.Add(en, ru);

                    }



                    keyPressed = Console.ReadKey(true);
                }
            }
        }
    }
}
