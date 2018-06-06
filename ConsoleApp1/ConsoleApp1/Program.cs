using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //pyramid with *'s
                //Console.WriteLine("enter a number:");
                //int n = int.Parse(Console.ReadLine());
                //for (int i = 1; i <n; i++)
                //{
                //    for (int j = 1; j <= n - i; j++)
                //        Console.Write(" ");
                //    for (int k = 1; k <= 2 * i - 1; k++)
                //        Console.Write("*");
                //    Console.Write("\n");
                //} 

                // pyramid with numbers

                Console.WriteLine("enter a number:");
                int n = int.Parse(Console.ReadLine());
                int sp = n - 1;
                for (int i = 1; i <= n; i++)
                {
                    for (sp = 1; sp <= (n - i); sp++)
                    { Console.Write(" "); }
                    for (int j = 1; j <= i; j++)
                    { Console.WriteLine(j); }
                    for (int k = (i - 1); k >= 1; k--)
                    { Console.Write(k); }
                    Console.WriteLine();
                }


            }





    // butterfly program on odd numbers
        class Program
        {
            static void Main(string[] args)
            {
                int r, h, d, sp;
                Console.Write("enter a number:");
                h = int.Parse(Console.ReadLine());
                h += 2;
                for (r = 1; r <= h - 1; r += 2)
                {
                    for (d = 1; d <= r; d += 2)
                        Console.Write(d);
                    Console.Write("\t");
                    for (sp = 1; sp <= 2 * (h - r); sp++)
                        Console.Write("");
                    for (d = r; d >= 1; d -= 2)
                        Console.Write(d);
                    Console.Write("\n");


                }
                for (r = h; r >= 1; r -= 2)
                {
                    for (d = 1; d <= r; d += 2)

                        Console.Write(d);
                    Console.Write("\t");
                    for (sp = 1; sp <= 2 * (h - r); sp++)
                        Console.WriteLine("");
                    for (d = r; d >= 1; d -= 2)
                        Console.Write(d);
                    Console.Write("\n");


                }
            }
         {
            //int n, r, sum = 0, temp;
            //Console.WriteLine("enter a number");
            //n = int.Parse(Console.ReadLine());
            //temp = n;
            //while (n > 0)
            //{
            //    r = n % 10;
            //    sum = (sum * 10) + r;         for palindrome ghnumber
            //    n = n / 10;


            //    //r = n % 10;
            //    //sum = sum + (r * r * r);      for armstrong number
            //    //n = n / 10;
            //}
            //if (temp == sum)
            //{
            //    Console.WriteLine("number is a palindrome number");
            //}
            //else
            //{
            //    Console.WriteLine("number is not a palindrome number");
            //}

            // factorial number
            int num, i, fact = 1;
            Console.WriteLine("enter a number:");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                fact = fact* i;
        }

        Console.WriteLine("Factorial of number" + num + "is:" + fact);
        }




}
}
