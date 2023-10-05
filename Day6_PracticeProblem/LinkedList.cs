using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_PracticeProblem
{
    internal class LinkedList
    {
        public class LinkedList<T>
        {
            private Node<T> head;
            private int count;

            public LinkedList()
            {
                head = null;
                count = 0;
            }
            public int Count
            {
                get { return count; }
            }
            public void AddFirst(T data)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = head;
                head = newNode;
                count++;
            }
            public void AddLast(T data)
            {
                Node<T> newNode = new Node<T>(data);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node<T> current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
                count++;
            }
            public bool Remove(T data)
            {
                if (head == null)
                    return false;

                if (head.Data.Equals(data))
                {
                    head = head.Next;
                    count--;
                    return true;
                }

                Node<T> current = head;
                while (current.Next != null)
                {
                    if (current.Next.Data.Equals(data))
                    {
                        current.Next = current.Next.Next;
                        count--;
                        return true;
                    }
                    current = current.Next;
                }

                return false;
            }
            public bool Contains(T data)
            {
                Node<T> current = head;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }
            public void Print()
            {
                Node<T> current = head;
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
    }
}
