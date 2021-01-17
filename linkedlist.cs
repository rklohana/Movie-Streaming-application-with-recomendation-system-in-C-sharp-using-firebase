using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RIOFLIX123
{
        public class SNode
        {
            internal moviedata data;
            internal SNode next;
            internal SNode(moviedata newnode)
        {
            data = new moviedata();
       //     MessageBox.Show("Name: " + newnode.Name);
            data.setdata(newnode.M_id,newnode.Name,newnode.Director,newnode.Genre,newnode.Actor,newnode.Keyword,newnode.Description,newnode.Videofile,newnode.Imagefile);
        }           
            
        }

        public class SingleLinkedList
        {
        int count;
            internal SNode head,tail;
        public SingleLinkedList()
        {
            count = 0;
            head = null;
            tail = null;
        }
     public   SNode gethead()
        {
            return head;
        }
        internal void InsertFront(moviedata new_data)
        {
            SNode new_node = new SNode(new_data);
            
            new_node.next = head;
            head = new_node;
            count++;
        }

        internal void InsertLast(moviedata new_data)
        {
            SNode new_node = new SNode(new_data);
            
            new_node.next = null;
            if (head == null)
            {
                count++;
                head = new_node;
                tail = new_node;
                return;
            }
            tail.next = new_node;
            tail = tail.next;
            count++;
        }

       
        public int getcount()
        {
            return count;
        }
       
        
        internal void DeleteNodebyKey(string key)
        {
            SNode temp = head;
            SNode prev = null;
            if (temp != null && temp.data.M_id.ToString() == key)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data.M_id.ToString() != key)
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