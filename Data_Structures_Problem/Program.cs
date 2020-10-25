using System;

namespace Data_Structures_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Data Structures Problem ");
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(70);
            linkedList.AddNode(56);
            linkedList.InsertElement(30, 2);
            linkedList.DeleteLastElement();
            Console.WriteLine("Linked List is: ");
            linkedList.Display();
        }
    }
}
