using System;

namespace Data_Structures_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Data Structures Problem ");
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(56);
            linkedList.AddNode(30);
            linkedList.AddNode(70);
            Console.WriteLine("Linked List is: ");
            linkedList.Display();
        }
    }
}
