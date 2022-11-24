using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureAlgorithm.DataStructurePrograms
{
    public class Stack<T>
    {
        public Node<T> top;
        public Stack()
        {
            this.top = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        public bool Peek()//will return top value but not delete it
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return true;
            }
            Console.WriteLine("{0} is in the top of the stack", this.top.data);
            return false;
        }
        public void Pop()//will delete top data nd return
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("Value Popped is {0}", this.top.data);
            this.top = this.top.next;
        }
        public void Display()
        {
            Node<T> temp = this.top;
            Console.WriteLine("Stack is as:");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
