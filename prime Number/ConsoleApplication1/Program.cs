using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Please Enter Frist Number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Other Number:");
            int num1 = int.Parse(Console.ReadLine());

            if (num < 2)
                num = 2;

            Console.WriteLine("The prime number is :");
            for (int a = num; a <= num1; a++)
            {
                for (int n = 2; n <= num1; n++)
                {
                    if (a != n && a % n == 0)
                    {
                        flag = false;
                        break;
                    }

                }
                if (flag)
                {
                    Console.WriteLine("\t" + a);
                }
                flag = true;


            }
        }
    }
}
