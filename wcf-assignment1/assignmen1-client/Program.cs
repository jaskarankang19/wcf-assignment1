using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmen1_client
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            OperationsReference.OperationsClient client = new OperationsReference.OperationsClient();
            while (!choice.Equals("6"))
            {
                Console.WriteLine("\t\tWCF Assignment 1");
                Console.WriteLine("1. Prime Numbers");
                Console.WriteLine("2. Sum of Digits");
                Console.WriteLine("3. Reverse a String");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit");

                Console.WriteLine("\tEnter your choice: ");
                choice = Console.ReadLine();
                int number = 0;
                int result = 0;
                string input = "";
                switch (choice)
                {

                    case "1":

                        Console.WriteLine("Enter a number to check for prime:");
                        number = int.Parse(Console.ReadLine());
                        bool isPrime = client.CheckPrime(number);
                        if (isPrime)
                        {
                            Console.WriteLine($"{number} is a prime number");
                        }
                        else
                        {
                            Console.WriteLine($"{number} is not a prime number");
                        }

                        break;
                    case "2":
                        Console.WriteLine("Enter a number to find sum of digits:");
                        number = int.Parse(Console.ReadLine());
                        result=client.DoSum(number);
                        Console.WriteLine($"Sum of digits: {result}");
                        break;
                    case "3":
                        Console.WriteLine("Enter a String to reverse:");
                        input = Console.ReadLine();
                        string rev = client.ReverseString(input);
                        Console.WriteLine($"Reversed string is: {rev}");
                        break;
                    case "4":
                        Console.WriteLine("Enter a HTML Tag:");
                        string tag = Console.ReadLine();
                        Console.WriteLine("Enter value to wrap with tag:");
                        string data = Console.ReadLine();
                        Console.WriteLine($"Output is: {client.CreateHtml(tag,data)}");
                        break;
                    case "5":
                        int[] arrInput = new int[5];
                        int[] arrResult = new int[5];
                        Console.WriteLine("Enter a sort type (Ascending or Descending):");
                        string sortType = Console.ReadLine();
                        Console.WriteLine("Enter 5 values to sort");
                        for (int i = 0; i <=4; i++)
                        {
                            Console.WriteLine($"Enter value:");
                            arrInput[i] = int.Parse(Console.ReadLine());
                        }
                        arrResult = client.SortNumbers(sortType, arrInput);
                        foreach (var item in arrResult)
                        {
                            Console.Write($"{item},");
                        }
                        break;
                }
            }
        }
    }
}
