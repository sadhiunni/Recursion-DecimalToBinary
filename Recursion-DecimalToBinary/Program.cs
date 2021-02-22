using System;
using System.Text;

/* Decimal to binary converter :
 * The user will input the number through the keyboard.
 * The number will be then converted to its binary version using recursion.
 */
namespace Recursion_DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder ReverseBinary = new StringBuilder();
            StringBuilder num = new StringBuilder();
            Console.WriteLine("****************************");
            Console.WriteLine("Decimal to binary converter!");
            Console.WriteLine("****************************");
            Console.WriteLine("Please enter the number : ");
            var number = Convert.ToInt32(Console.ReadLine());
            
            ReverseBinary = DecToBin(number,num);

            Console.WriteLine("\nThe number has been converted to its binary format : ");
            for (int i = ReverseBinary.Length-1; i>=0 ; i--)
            {
                Console.Write(ReverseBinary[i]);
            }
            Console.WriteLine("\n");
        }
        public static StringBuilder DecToBin(int number,StringBuilder num)
        {

            if (number != 1)
            {
                num.Append(number % 2);
                DecToBin(number / 2,num);
                return num;
            }
            else
                return num.Append(1);
        }
    }
}
