using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result=Add2(15, 30);
            //Console.WriteLine(result);

            Console.WriteLine(Multiply(2, 2));
            Console.WriteLine(Multiply(2, 3, 4));

            Console.WriteLine(Params(2, 3, 4));


            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        //Method overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3) //method signature
        {
            return number1 * number2 * number3;
        }

        //params
        static int Params(params int[] numbers)
        {
            return numbers.Sum();
        }

        //string methods
        static void Main2(string[] args)
        {
            string sentence = "My name is Semih";

            var result = sentence.Length;
            var result1 = sentence.Clone();

            bool result2 = sentence.EndsWith("h");
            bool result3 = sentence.StartsWith("My");

            var result5 = sentence.IndexOf("  ");
            var result6 = sentence.LastIndexOf("  ");
            var result7 = sentence.Insert(0, "Hello, ");
            var result8 = sentence.Substring(3, 4);

            var result9 = sentence.ToLower();
            var result10 = sentence.ToUpper();
            var result11 = sentence.Replace(" ", "-");
            var result12 = sentence.Remove(2);




            Console.ReadLine();
        }

    }
}
