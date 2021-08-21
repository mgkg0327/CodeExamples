using System;

namespace Exceptions_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 0;
            try {
                Console.WriteLine(num1 / num2);
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
