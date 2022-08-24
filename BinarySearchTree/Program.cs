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
                "1)Enter elements in the Binary Search Tree\n");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    BinarySearch<int> binary = new BinarySearch<int>(56);        //56 taken as a root element
                    binary.Add(30);
                    binary.Add(70);
                    Console.WriteLine("::::::::::::::::::::::::::::::::::");
                    Console.Write("Root Node is : ");
                    binary.Display();
                    break;

                default:

                    Console.WriteLine("Please enter Proper option");
                    break;
            }
        }
    }
}