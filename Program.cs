using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task 1
            //int count = 0;

            //char end = '.';
            //char enter = ' ';

            //while (enter != end)
            //{
            //    enter = Convert.ToChar(Console.ReadLine());
            //    if (enter == ' ') { count++; };
            //}
            //Console.WriteLine($"Result is: {count}");
            //Task 2
            //Console.WriteLine("Enter ticket code:");
            //int num=Convert.ToInt32(Console.ReadLine());
            //int num1 = num % 10;
            //int num2 = num / 10 % 10;
            //int num3 = num / 100 % 10;
            //int num4 = num / 1000 % 10;
            //int num5 = num / 10000 % 10;
            //int num6 = num / 100000 % 10;


            //if ((num1 + num2 + num3) == (num4 + num5 + num6)&&(num/ 1000000 % 10)==0) 
            //{
            //    Console.WriteLine("Ticket is lucky...");

            //}
            //else if ( (num / 1000000 % 10) != 0)
            //{
            //    Console.WriteLine("Ticket code can not contain more than 6 numbers...");

            //}
            //else {

            //    Console.WriteLine("Ticket is unlucky...");
            //}
            //Task 3

            //string str1 = Console.ReadLine();

            //char[] Array = str1.ToCharArray();

            //for (int i = 0; i < str1.Length; i++)
            //{
            //    if (str1[i] <= 122 && str1[i] >= 97)
            //    {
            //       Array[i] =char.ToUpper(Array[i]);
            //    }
            //    else if (str1[i] <= 90 && str1[i] >= 65)
            //    {
            //        Array[i] = char.ToLower (Array[i]);
            //    }

            //}

            //Console.WriteLine(Array);
            //Task 4
            //Console.WriteLine("Enter A");
            //int A=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter B");
            //int B= Convert.ToInt32(Console.ReadLine());
            //int size = B - A + 1;
            //int[][] arr = new int[size][];

            //for (int i = A,k=0 ; i < B+1; i++,k++)
            //{
            //    arr[k] = new int[i];
            //}

            //for (int i = A,k=0; i < B + 1; i++,k++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        arr[k][j] = i;
            //    }

            //}
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Task 5

            string num1 = Console.ReadLine();
           
            string num2= new string( num1.Reverse().ToArray());
            Console.WriteLine(num2);

        }
    }
}
