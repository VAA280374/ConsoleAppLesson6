using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vStr = Console.ReadLine();
            // Console.WriteLine(vStr);
            string[] vStrArray = vStr.Split();
            string vResult = "";
            int vStrLenght = 0;
            foreach (string str in vStrArray)
            { 
                Console.WriteLine(str);
                if (vStrLenght < str.Length)
                {
                    vStrLenght = str.Length;
                    vResult = str;
                }
    
                // Console.WriteLine("{0}", vStrLenght);
            }
            Console.Write("Самое длинное слово во введённой строке : ");
            Console.WriteLine(vResult);
            Console.ReadKey();
        }
    }
}
