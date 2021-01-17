using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RIOFLIX123
{
    class node
    {
        public double val;
        public int idx;
        public node next;
    }
    class duallinkedlist : node
    {
        node head;
        node tail;
        public duallinkedlist()
        {
            head = null;
            tail = null;
        }

        public void addlist(int i, double val1)
        {
            node temp = new node();
            temp.idx = i;
            temp.val = val1;
            temp.next = null;
            if (head == null)
            {
                head = temp;
                tail = temp;
                return;
            }
            tail.next = temp;
            tail = temp;

        }



        node sortedMerge(node a, node b)
        {
            node result = null;
            /* Base cases */
            if (a == null)
                return b;
            if (b == null)
                return a;

            /* Pick either a or b, and recur */
            if (a.val >= b.val)
            {
                result = a;
                result.next = sortedMerge(a.next, b);
            }
            else
            {
                result = b;
                result.next = sortedMerge(a, b.next);
            }
            return result;
        }

        node mergeSort(node h)
        {
            // Base case : if head is null 
            if (h == null || h.next == null)
            {
                return h;
            }

            // get the middle of the list 
            node middle = getMiddle(h);
            node nextofmiddle = middle.next;

            // set the next of middle node to null 
            middle.next = null;

            // Apply mergeSort on left list 
            node left = mergeSort(h);

            // Apply mergeSort on right list 
            node right = mergeSort(nextofmiddle);

            // Merge the left and right lists 
            node sortedlist = sortedMerge(left, right);
            return sortedlist;
        }

        // Utility function to get the 
        // middle of the linked list 
        node getMiddle(node h)
        {
            // Base case 
            if (h == null)
                return h;
            node fastptr = h.next;
            node slowptr = h;

            // Move fastptr by two and slow ptr by one 
            // Finally slowptr will point to middle node 
            while (fastptr != null)
            {
                fastptr = fastptr.next;
                if (fastptr != null)
                {
                    slowptr = slowptr.next;
                    fastptr = fastptr.next;
                }
            }
            return slowptr;
        }
        public void sortlist()
        {
            head = mergeSort(head);
        }

        public void traversal()
        {
            string l = "";
            node temp = head;
            while (temp != null)
            {
                l += temp.val.ToString() + " ";

                temp = temp.next;
            }
            MessageBox.Show(l);
        }



        public int[] retnum(int n)
        {
            node temp = head.next;
            int[] n1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (temp == null)
                {
                    break;
                }
                else
                {
                    n1[i] = temp.idx;
                    temp = temp.next;
                }
            }



            return n1;
        }

    }
}
