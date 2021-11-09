using System;
using System.IO;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your horoscope sign:");
            string usersign = Console.ReadLine();
            Console.WriteLine(Gethoroscope(usersign));
            
        }

        public static string[] Readhoroscope()
        {
            string filepath = @"C:\Users\opilane\Samples\horoscope.txt";
            string[] datafromfile = File.ReadAllLines(filepath);
            
            

            return datafromfile;
        } 
        public static string Gethoroscope(string userinput)
        {
            string[] horoscope = Readhoroscope();
            string todayhoroscope = "";
            foreach(string element in horoscope)
            {
                if (element.Contains(userinput))
                {
                    todayhoroscope = element;
                }   
                
            }
            return todayhoroscope;
        }

    }
}
