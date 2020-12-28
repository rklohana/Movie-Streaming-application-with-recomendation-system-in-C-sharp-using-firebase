using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIOFLIX123
{
   
        internal class QNode
        {
            internal string data;
            internal QNode next;

            // Constructor to create a new node.Next is by default initialized as null  
            public QNode(string d)
            {
                data = d;
                next = null;
            }
        }
        internal class Queue
        {
            QNode front;
            QNode rear;
        int cont;
            public Queue()
            {
            cont = 0;
                this.front = this.rear = null;
            }

            internal void Enqueue(string item)
            {
                QNode newNode = new QNode(item);

                // If queue is empty, then new node is front and rear both  
                if (this.rear == null)
                {
                    this.front = this.rear = newNode;
                }
                else
                {
                    // Add the new node at the end of queue and change rear  
                    this.rear.next = newNode;
                    this.rear = newNode;
                }
            cont++;
                //Console.WriteLine("{0} inserted into Queue", item);
            }

            public string Dequeue()
            {
                // If queue is empty, return NULL.  
                if (this.front == null)
                {
                    //Console.WriteLine("The Queue is empty");
                    return null;
                }

                // Store previous front and move front one node ahead  
                QNode temp = this.front;
                this.front = this.front.next;
            cont--;
                // If front becomes NULL, then change rear also as NULL  
                if (this.front == null)
                {
                    this.rear = null;
                }

            //Console.WriteLine("Item deleted is {0}", temp.data);
            return temp.data;
            }
            public string Peek()
            {
                if (front == null)
                {
                    //Console.WriteLine("Stack Underflow.");
                    return null;
                }

            // Console.WriteLine("{0} is on the front of Queue", this.front.data);
            return front.data;
        }


        public bool isempty()
        {
            if (front == null)
            {
                return true;
            }
            return false;
        }


        public int getsize()
        {
            return cont;
        }





    }




    }

