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
            string s = "XVII";
            RomanToInt(s);
        }

        static int RomanToInt(string s)
        {
            if (s.Length > 15)
            {
                Console.WriteLine("String Is More than 15 Disgit");
                Console.ReadLine();
            }
            else if (s.Length >= 1 && s.Length <= 15)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    var st = Convert.ToInt32(GetStringValue(s[i].ToString()));

                    Console.WriteLine(st);
                    Console.ReadLine();
                }
            }


        }

        static string GetStringValue(string userInput)
        {

            if (userInput == "I")
            {
                return userInput = "1";
            }
            else if (userInput == "V")
            {
                return userInput = "5";
            }
            else if (userInput == "X")
            {
                return userInput = "10";

            }
            else if (userInput == "L")
            {
                return userInput = "50";
            }
            else if (userInput == "C")
            {
                return userInput = "100";
            }
            else if (userInput == "D")
            {
                return userInput = "500";
            }
            else if (userInput == "M")
            {
                return userInput = "1000";
            }

            return userInput;
        }
    }
}
