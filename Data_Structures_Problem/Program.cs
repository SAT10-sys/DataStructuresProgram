using System;

namespace Data_Structures_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Data Structures Problem ");
            bool flag = true;
            int element;
            int position;
            LinkedList list = new LinkedList();
            while (flag)
            {
                Console.WriteLine("\n");
                Console.WriteLine("1.Add Node\n2.Change Node\n3.Insert in between node\n4.Delete First node\n5.Delete Last node\n6.Search element\n7.Insert after node\n8.Delete node\n9.Display Sorted List\n10.Exit");
                Console.WriteLine("Enter Choice");
                int choiceOfOperation = Convert.ToInt32(Console.ReadLine());
                switch (choiceOfOperation)
                {
                    case 1:
                        Console.WriteLine("Enter elements to add");
                        element = Convert.ToInt32(Console.ReadLine());
                        list.AddNode(element);
                        Console.WriteLine("Linked list is: ");
                        list.Display();
                        break;
                    case 2:
                        Console.WriteLine("Enter elements to append");
                        element = Convert.ToInt32(Console.ReadLine());
                        list.ChangeNode(element);
                        Console.WriteLine("Linked list is: ");
                        list.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter elements to insert");
                        element = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the position");
                        position = Convert.ToInt32(Console.ReadLine());
                        if (position > list.size() || position < 1)
                        {
                            Console.WriteLine("Invalid position.Enter position less than " + list.size());
                            break;
                        }
                        list.InsertElement(element, position);
                        Console.WriteLine("Linked list is: ");
                        list.Display();
                        break;
                    case 4:
                        list.DeleteFirstElement();
                        Console.WriteLine("Linked list is: ");
                        list.Display();
                        break;
                    case 5:
                        list.DeleteLastElement();
                        Console.WriteLine("Linked list is: ");
                        list.Display();
                        break;
                    case 6:
                        Console.WriteLine("Enter Element to be searched");
                        element = Convert.ToInt32(Console.ReadLine());
                        position = list.SearchList(element);
                        if (position == 0)
                            Console.WriteLine("No element found");
                        else
                            Console.WriteLine("Element found at position " + position);
                        break;
                    case 7:
                        Console.WriteLine("Enter Element after which node is to be added");
                        int element1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the element to be added");
                        int element2 = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfterElement(element2, element1);
                        Console.WriteLine("Linked list is: ");
                        list.Display();
                        break;
                    case 8:
                        Console.WriteLine("Enter the node to be deleted");
                        element = Convert.ToInt32(Console.ReadLine());
                        list.DeleteMiddleNode(element);
                        Console.WriteLine("Linked list is: ");
                        list.Display();
                        break;
                    case 9:
                        OrderedLinkedList orderedLinkedList = new OrderedLinkedList();
                        orderedLinkedList.AddElement(56);
                        orderedLinkedList.AddElement(30);
                        orderedLinkedList.AddElement(70);
                        orderedLinkedList.AddElement(50);
                        orderedLinkedList.Display();
                        break;
                    case 10:
                        flag = false;
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
