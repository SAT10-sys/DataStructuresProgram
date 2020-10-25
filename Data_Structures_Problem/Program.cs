using System;

namespace Data_Structures_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Data Structures Problem ");
            OrderedLinkedList orderedLinkedList = new OrderedLinkedList();
            orderedLinkedList.AddElement(56);
            orderedLinkedList.AddElement(30);
            orderedLinkedList.AddElement(40);
            orderedLinkedList.AddElement(70);
            orderedLinkedList.Display();
        }
    }
}
