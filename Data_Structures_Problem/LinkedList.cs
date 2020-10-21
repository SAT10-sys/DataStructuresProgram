using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_Problem
{
    public class LinkedList
    {
        public Node head;
        public void AddNode(int data)
        {
            Node node = new Node(data);
            if (head == null)
                this.head = node;
            else
            {
                Node temp = node;
                temp.next = head;
                head = temp;
            }
        }
        public void ChangeNode(int data)
        {
            Node node = new Node(data);
            if (head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = node;
            }
        }
        public void InsertElement(int data, int positionToInsert)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node temp = head;
            for (int i = 1; i < positionToInsert - 1; i++)
                temp = temp.next;
            node.next = temp.next;
            temp.next = node;
        }
        internal void Display()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
