using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.DataStructurePrograms
{
    public class LinkedList<T>
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("\"{0}\" inserted into linked list", node.data);
        }
        public void Delete(T data)
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            if (head.data.Equals(data))
            {
                head = head.next;
                return;
            }
            Node<T> prev = head;
            Node<T> temp = head.next;
            while (temp != null)
            {
                if (temp.data.Equals(data))
                {
                    prev.next = temp.next;
                    temp = null;
                    return;
                }
                prev = temp;
                temp = temp.next;
            }
        }
        public void Display()
        {
            Node<T> temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            Console.WriteLine("LinkedList is as");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
