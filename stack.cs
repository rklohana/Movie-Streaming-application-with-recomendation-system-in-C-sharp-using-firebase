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

            public Stack()
            {
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
             //   Console.WriteLine("{0} pushed to stack", value);
            }

            internal void Pop()
            {
                if (top == null)
                {
                  //  Console.WriteLine("Stack Underflow. Deletion not possible");
                    return;
                }

               // Console.WriteLine("Item popped is {0}", top.data);
                top = top.next;
            }
        public Node rethead()
        {
            return top;
        }

            internal void Peek()
            {
                if (top == null)
                {
                   // Console.WriteLine("Stack Underflow.");
                    return;
                }

               // Console.WriteLine("{0} is on the top of Stack", this.top.data);
            }
        }
    }

