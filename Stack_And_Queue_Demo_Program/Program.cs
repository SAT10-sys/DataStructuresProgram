using System;

namespace Stack_And_Queue_Demo_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Stack Program ");
            StackOperation stackOperation = new StackOperation();
            stackOperation.Push(70);
            stackOperation.Push(30);
            stackOperation.Push(56);
            Console.WriteLine("Stack is: ");
            stackOperation.Display();
            stackOperation.Pop();
            Console.WriteLine("\n");
            Console.WriteLine("Stack is :");
            stackOperation.Display();
            Console.WriteLine("\n");
            stackOperation.Peep();
            QueueOperations queue = new QueueOperations();
            queue.Enqueue(53);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("Queue is: ");
            queue.Display();
            queue.Dequeue();
            Console.WriteLine("After Dequeue operation: ");
            queue.Display();
        }
    }
}
