using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите предложение не используя знаки препинания");
            Console.WriteLine();

            string S1 = Console.ReadLine();
            string S2 = S1.Replace(" ", "").ToLower();
            char [] S3 = S2.ToCharArray();
            Array.Reverse(S3);
            string S4 = new string(S3);
            Console.WriteLine();
            //Console.WriteLine(S2);
            //Console.WriteLine();
            Console.WriteLine(S4);
            Console.WriteLine();

            bool result = char.Equals(S2, S4);
            
            {
                if (result == true)
                {
                    Console.WriteLine("Палиндром найден");
                   
                }
                if (result == false)
                {
                    Console.WriteLine("Палиндром не найден");
                }
            }

//На будущее по второму заданию. Так как переменная result булевая, то вместо if (result == true) будет эквивалентно написать if (result), 
//а проверка на false будет if (!result). 
//И так как у вас всего одно действие, то можно написать все в одну строчку или вовсе использовать тернарный оператор, например:
//string vivod = "";
//if (result)? vivod = "Палиндром найден":vivod = "Палиндром не найден";
//Console.WriteLine(vivod);

           
           
            Console.ReadKey();
        }
    }
}
