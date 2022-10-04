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

        static void getNumber(int I, int V, int X, int L, int C,int D, int M)
        {

        }
    }
}
