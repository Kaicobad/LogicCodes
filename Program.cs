using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s.Length > 15)
            {
                Console.WriteLine("String Is More than 15 Disgit");
                Console.ReadLine();
            }
            else if (s.Length >= 1 && s.Length <= 15)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    Console.WriteLine(s[i]);
                    Console.ReadLine();
                }
            }   
        }

        static void getStringValue(string userInput)
        {

            string I = 1.ToString();
            string V = 5.ToString();
            string X = 10.ToString();
            string L = 50.ToString();
            string C = 100.ToString();
            string D = 500.ToString();
            string M = 1000.ToString();


        }
    }
}
