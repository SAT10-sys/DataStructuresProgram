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
            }
            Node temp = head;
            for (int i = 1; i < positionToInsert - 1; i++)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
        }
        public Node DeleteFirstElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
                return null;
            }
            Node temp = this.head;
            head = head.next;
            temp.next = null;
            return head;
        }
        public Node DeleteLastElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
                return null;
            }
            if (this.head.next == null)
            {
                Console.WriteLine("List Only Has One Element");
                return null;
            }
            Node temp = this.head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
            return temp;
        }
        public int SearchList(int data)
        {
            int count = 1;
            Node temp = head;
            if (this.head == null)
            {
                return 0;
            }
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return count; ;
                }
                temp = temp.next;
                count++;
            }
            return 0;
        }
        public void InsertAfterElement(int element, int data)
        {
            int position = SearchList(data);
            if (position == 0)
            {
                Console.WriteLine("No such element found");
                return;
            }
            Node node = new Node(element);
            Node temp = this.head;
            for (int i = 1; i < position; i++)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;

        }
        public void DeleteMiddleNode(int element)
        {
            int position = SearchList(element);
            if (position == 0)
            {
                Console.WriteLine("No such element found");
                return;
            }
            Node temp = head;
            for (int i = 1; i < position - 1; i++)
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;

        }
        public int size()
        {
            int count = 0;
            Node temp = head;
            if (temp == null)
            {
                return 0;
            }
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
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
