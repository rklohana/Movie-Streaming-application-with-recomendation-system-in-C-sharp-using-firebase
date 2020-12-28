using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIOFLIX123
{
        internal class SNode
        {
            internal string data;
            internal SNode next;
            public SNode(string d)
            {
                data = d;
                next = null;
            }
        }

        internal class SingleLinkedList
        {
            internal SNode head;

        internal void InsertFront(string new_data)
        {
            SNode new_node = new SNode(new_data);
            new_node.next = head;
            head = new_node;
        }

        internal void InsertLast(string new_data)
        {
            SNode new_node = new SNode(new_data);
            if (head == null)
            {
                head = new_node;
                return;
            }
            SNode lastNode = GetLastNode(this);
            lastNode.next = new_node;
        }

        internal SNode GetLastNode(SingleLinkedList singlyList)
        {
            SNode temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal void InsertAfter(SNode prev_node, string new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            SNode new_node = new SNode(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }

        internal void DeleteNodebyKey(string key)
        {
            SNode temp = head;
            SNode prev = null;
            if (temp != null && temp.data == key)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

    }



}
/*
 * 
 * 
 * 
*/