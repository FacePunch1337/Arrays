using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicks2
{
    partial class App
    {
        int[] arr1;
        int[,] arr2;
        int[][] arr3;

        public void CtorDemo() 
        {
            TheClass obj = new TheClass(20);
            obj.Y = 10;
            obj.Y = obj.W + 10;
           
            Console.WriteLine(obj);
        }
        public void Run()
        {

            //CtorDemo();
            CollectionsDemo();



        }

        public void CollectionsDemo()
        {
            List<String> strings;
            Dictionary<String, String> dict;

            strings = new List<string>();
            strings.Add("String 1");
            strings.Add("String 2");
            strings.Add("String 3");
            foreach(String item in strings)
            {
                Console.WriteLine(item);
            }
            
        }
        public void ArraysDemo()
        {
            Console.WriteLine("О массивах и коллекциях");

            arr1 = new int[10];

            for (int i = 0; i < 5; i++)
            {
                arr1[i] = i * i;
            }
            foreach (int x in arr1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("--------------");
            Console.WriteLine("array size: " + arr1.Length);

            arr2 = new int[3, 4];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    arr2[i, j] = 10 * i + j + 11;
                }
            foreach (var x2 in arr2)
            {
                Console.WriteLine(x2);
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }

            arr3 = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                arr3[i] = new int[2 + i];
                for (int j = 0; j < 2 + i; j++)
                {
                    arr3[i][j] = 10 * i + j + 11;
                }
            }
            foreach (var x2 in arr3)
            {
                foreach (var x in x2)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
        }
    }

    public class TheClass
    {
        private int x;
        public int Y { get; set; }
        public int W { get; private set; }
        public int X {
            get { return this.x; }
            private set { this.x = value;  }
        }


        private TheClass()
        {
            x = 10;
        }

        public TheClass(int x)
        {
            this.x = x;
        }


        public override string ToString()
        {
            return $"x = {this.x}";
        }
    }
}
