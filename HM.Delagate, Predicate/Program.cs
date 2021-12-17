using System;

namespace HM.Delagate__Predicate
{
    using System;
    using System.Collections.Generic;

    namespace Delegates
    {
        class Program
        {
            //public delegate bool Check(int num);
            // public delegate void ChangeWords(string str);
            // public delegate string Print(string str);

            static void Main(string[] args)
            {

                //Console.WriteLine(Sum(m => m%2 == 0, 1, 2, 3, 4, 5, 6, 7));
                //Console.WriteLine(Sum(CheckEven, 1, 2, 3, 4, 5, 6, 7));
                //Console.WriteLine(Sum(CheckNum, 1, 2, 3, 4, 5, 6, 7));

                //List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6,7 };

                //  var list = nums.FindAll();

                //foreach (var item in list)
                //{
                //    Console.WriteLine(item);
                //}

                //String name = "Rovshen";

                //Console.WriteLine(name);


                //List<int> nums = new List<int>();


                //Action<string,int> words = StringToUpper;
                //words += StringToLower;
                //words("BEXtiyar",5);
                //words("Rovshen", 10);

                Func<string, string> print = StrLength;
                Console.WriteLine(print("Seid"));

                //Person person = new Person();
                //Console.WriteLine(GetPerson(person));



            }



            public static string StrLength(string s)
            {
                return s;
            }


            public static void StringToUpper(string str, int t)
            {
                Console.WriteLine(str.ToUpper() + "-" + t);
            }

            public static void StringToLower(string str, int c)
            {
                Console.WriteLine(str.ToLower() + "-" + c);
            }


            public static bool CheckEven(int num)
            {
                return num % 2 == 0;
            }

            public static bool CheckNum(int num)
            {
                return num > 5;
            }



            public static int Sum(Predicate<int> func, params int[] nums)
            {
                var sum = 0;
                foreach (var item in nums)
                {
                    if (func(item))
                    {
                        sum += item;
                    }
                }

                return sum;
            }



            public static Person GetPerson(Person person)
            {
                return person;
            }
        }

        public class Person
        {
            public string Name { get; set; }
        }
    }
}
