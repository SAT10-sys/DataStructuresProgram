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
            Console.WriteLine("Linked List is: ");
            linkedList.Display();
            Console.WriteLine("\n");
            Console.WriteLine("Enter the element to be searched");
            int element = Convert.ToInt32(Console.ReadLine());
            int position = linkedList.SearchList(element);
            if(position==0)
                Console.WriteLine("No such element found");
            else
                Console.WriteLine("Element found at position: "+position);
        }
    }
}
