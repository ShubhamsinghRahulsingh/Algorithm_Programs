﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureAlgorithm.DataStructurePrograms
{
    public class ATMQueue<T>
    {
        Node<T> head = null;
        public void Enqueue(T data)
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
        }
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("ATM Queue is Empty.");
                return;
            }
            else
            {
                this.head = this.head.next;
            }
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Console.WriteLine("ATM Queue is as:");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
