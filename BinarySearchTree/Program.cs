using System;

namespace BinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program");

            bool check = true;
            

            Console.WriteLine("Select Options :\n" + 
                "1)Enter elements in the Binary Search Tree\n" +
                "2)Added Elements from the Figure and Get the size\n");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    BinarySearch<int> binary = new BinarySearch<int>(56);        //56 taken as a root element
                    binary.Insert(30);
                    binary.Insert(70);
                    Console.WriteLine("::::::::::::::::::::::::::::::::::");
                    Console.Write("Root Node is : ");
                    binary.Display();
                    break;

                case 2:

                    BinarySearch<int> binary1 = new BinarySearch<int>(56);        //56 taken as a root element
                    binary1.Insert(30);
                    binary1.Insert(70);
                    binary1.Insert(22);
                    binary1.Insert(40);
                    binary1.Insert(60);
                    binary1.Insert(95);
                    binary1.Insert(11);
                    binary1.Insert(65);
                    binary1.Insert(3);
                    binary1.Insert(16);
                    binary1.Insert(63);
                    binary1.Insert(67);
                    Console.WriteLine("::::::::::::::::::::::::::::::::::");
                    Console.Write("Root Node is : ");
                    binary1.Display();
                    Console.WriteLine("::::::::::::::::::::::::::::::::::");

                    binary1.Getsize();
                    Console.WriteLine("::::::::::::::::::::::::::::::::::");

                    break;



                default:

                    Console.WriteLine("Please enter Proper option");
                    break;
            }
        }
    }
}