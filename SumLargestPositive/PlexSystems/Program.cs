using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFormat = "input Format array elements saperated with ',' |n (n saperated by '|')";
            Console.WriteLine(inputFormat);
            Console.WriteLine("Examples");
            List<string> inPutString = new List<string>();
            inPutString.Add(" 1,1|6");
            inPutString.Add(" 1,1|6");
            foreach (var item in inPutString)
            {
                Console.WriteLine("Examples:");
                Console.WriteLine(item);
                string[] input = item.Split('|');
                IEnumerable<int> intArray = StringToIntList(input[0]);
                int num;
                if (int.TryParse(input[1].Trim(), out num))
                {
                    PlexChallengeFibonacci feb = new PlexChallengeFibonacci();
                    int[] result = feb.fibonacciSequence(intArray.ToArray(), num);
                    Console.WriteLine("Result:");
                    Console.WriteLine(string.Join(",", result));
                }

            }
            //string inputFormat = "input Format array elements saperated with ',' |n (n saperated by '|')";
            Console.WriteLine();
            Console.WriteLine(inputFormat);
            Console.WriteLine("Please enter input in 1,2,3,4|6 format. If you want you close the application enter close");
            var val = Console.ReadLine();

            while (!val.ToLower().Contains("close"))
            {
                string[] input = val.Split('|');
                if (input.Length == 2)
                {
                    IEnumerable<int> intArray = StringToIntList(input[0]);
                    int num;
                    if (int.TryParse(input[1].Trim(), out num))
                    {
                        PlexChallengeFibonacci feb = new PlexChallengeFibonacci();
                        int[] result = feb.fibonacciSequence(intArray.ToArray(), num);
                        Console.WriteLine("Result:");
                        Console.WriteLine(string.Join(",", result));
                    }                                     
                }
                else
                { Console.WriteLine("Invalid Input"); }
                Console.WriteLine();
                Console.WriteLine("Please enter input in 1,2,3,4|6 format.");
                Console.WriteLine("If you want you close the application enter close");
                Console.WriteLine();
                val = Console.ReadLine();
            }
        }
        public static IEnumerable<int> StringToIntList(string str)
        {
            if (String.IsNullOrEmpty(str))
                yield break;

            foreach (var s in str.Split(','))
            {
                int num;
                if (int.TryParse(s, out num))
                    yield return num;
            }
        }
    }
}
