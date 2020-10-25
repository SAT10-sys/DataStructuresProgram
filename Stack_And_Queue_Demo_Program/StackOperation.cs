using System;
using System.Collections.Generic;
using System.Text;
using Data_Structures_Problem;

namespace Stack_And_Queue_Demo_Program
{
    public class StackOperation
    {
        Node top;
        public void Push(int element)
        {
            Node node = new Node(element);
            if (top == null)
                this.top = node;
            else
            {
                Node temp = node;
                temp.next = top;
                top = temp;
            }
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Node temp = this.top;
            top = top.next;

        }
        public void Peep()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is null");
            }
            Console.WriteLine("Peep :" + top.data);
        }
        public void Display()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
