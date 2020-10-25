using System;
using System.Collections.Generic;
using System.Text;
using Data_Structures_Problem;

namespace Stack_And_Queue_Demo_Program
{
    public class QueueOperations
    {
        Node front;
        public void Enqueue(int element)
        {
            Node node = new Node(element);
            if (front == null)
                this.front = node;
            else
            {
                Node temp = front;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void Display()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue  is empty");
                return;
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
