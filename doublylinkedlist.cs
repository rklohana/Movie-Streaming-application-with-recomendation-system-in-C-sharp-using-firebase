using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIOFLIX123
{
        internal class DNode
        {
            internal string data;
            internal DNode prev;
            internal DNode next;
            public DNode(string d)
            {
                data = d;
                prev = null;
                next = null;
            }
        }

        internal class DoubleLinkedList
        {
            internal DNode head;
            internal void InsertFront(string data)
            {
                DNode newNode = new DNode(data);
                newNode.next = head;
                newNode.prev = null;
                if (head != null)
                {
                    head.prev = newNode;
                }
                head = newNode;
            }
        internal void InsertLast(string data)
        {
            DNode newNode = new DNode(data);
            if (head == null)
            {
                newNode.prev = null;
                head = newNode;
                return;
            }
            DNode lastNode = GetLastNode(this);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }
        internal DNode GetLastNode(DoubleLinkedList doublyList)
        {
            DNode temp = doublyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal void InsertAfter(DNode prev_node, string data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given prevoius node cannot be null");
                return;
            }
            DNode newNode = new DNode(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
            newNode.prev = prev_node;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }

        internal void DeleteNodebyKey(string key)
        {
            DNode temp = head;
            if (temp != null && temp.data == key)
            {
                head = temp.next;
                head.prev = null;
                return;
            }
            while (temp != null && temp.data != key)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }

    }


    
    }
