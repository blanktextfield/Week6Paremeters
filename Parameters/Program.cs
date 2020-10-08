using System;
using System.Security.Cryptography.X509Certificates;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsSum(50, 50);
            DisplayString("Some random string");
        }
        public static void ParamsSum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }    public static void DisplayString(string someString)     
        {  
            Console.WriteLine(someString);
        }  
    }
}
