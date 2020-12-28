using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIOFLIX123
{
        internal class Node
        {
            internal string data;
            internal Node next;

            // Constructor to create a new node.Next is by default initialized as null  
            public Node(string d)
            {
                data = d;
                next = null;
            }
        }

        internal class Stack
        {
            Node top;
            int cont;
            public Stack()
            {
            cont = 0;
                this.top = null;
            }
            internal void Push(string value)
            {
                Node newNode = new Node(value);
                if (top == null)
                {
                    newNode.next = null;
                }
                else
                {
                    newNode.next = top;
                }
                top = newNode;
            cont++;
               // Console.WriteLine("{0} pushed to stack", value);
            }

           public string Pop()
            {
                if (top == null)
                {
                //    Console.WriteLine("Stack Underflow. Deletion not possible");
                return null ;
                }
            cont--;
            var n = top.data;
              //  Console.WriteLine("Item popped is {0}", top.data);
                top = top.next;
            return n;
            }
            bool isempty()
        {
            if (top == null)
            {
                return true;
            }
            return false;
        }
            public string Peek()
            {
                if (top == null)
                {
                /// Console.WriteLine("Stack Underflow.");
                return null ;
                }
            return top.data;

                //Console.WriteLine("{0} is on the top of Stack", this.top.data);
            }

        public int getsize()
        {
            return cont;
        }
        }
    }

