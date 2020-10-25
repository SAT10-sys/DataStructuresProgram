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
        }
    }
}
