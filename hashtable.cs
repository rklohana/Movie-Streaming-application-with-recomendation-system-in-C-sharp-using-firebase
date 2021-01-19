using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace RIOFLIX123
{
    public class AVL
    {
       public class BNode
        {
            public moviedata data;
            public BNode left;
            public BNode right;
            public char name;
            public BNode(moviedata newnode)
            {   
                data = new moviedata();
                //     MessageBox.Show("Name: " + newnode.Name);
                data.setdata(newnode.M_id, newnode.Name, newnode.Director, newnode.Genre, newnode.Actor, newnode.Keyword, newnode.Description, newnode.Videofile, newnode.Imagefile);
                name = data.getname()[0];
            }
        }
        BNode root;
        public AVL()
        {
        }
        public void Add(moviedata data)
        {
           BNode newItem = new BNode(data);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                root = RecursiveInsert(root, newItem);
            }
        }
        
        
        private BNode RecursiveInsert(BNode current, BNode n)
        {
            if (current == null)
            {
                current = n;
                return current;
            }
            else if (n.name < current.name)
            {
                current.left = RecursiveInsert(current.left, n);
                current = balance_tree(current);
            }
            else if (n.name >= current.name)
            {
                current.right = RecursiveInsert(current.right, n);
                current = balance_tree(current);
            }
            return current;
        }
        private BNode balance_tree(BNode current)
        {
            int b_factor = balance_factor(current);
            if (b_factor > 1)
            {
                if (balance_factor(current.left) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (b_factor < -1)
            {
                if (balance_factor(current.right) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }


        public moviedata find(string n)
        {
            return find(root, n);
        }

        public moviedata find(BNode leaf, string n)
        {
            if (leaf != null) {
                if (leaf.data.Name == n)
                {
                    return leaf.data;
                }
                if (leaf.name < n[0])
                {
                    return find(leaf.left, n);
                }
                else
                {
                    return find(leaf.right, n);
                }
            }
            return null;
        }
       
       
        public void DisplayTree()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            InOrderDisplayTree(root);
            Console.WriteLine();
        }
        private void InOrderDisplayTree(BNode current)
        {
            if (current != null)
            {
                InOrderDisplayTree(current.left);
                Console.Write("({0}) ", current.data);
                InOrderDisplayTree(current.right);
            }
        }
        private int max(int l, int r)
        {
            return l > r ? l : r;
        }
        private int getHeight(BNode current)
        {
            int height = 0;
            if (current != null)
            {
                int l = getHeight(current.left);
                int r = getHeight(current.right);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }
        private int balance_factor(BNode current)
        {
            int l = getHeight(current.left);
            int r = getHeight(current.right);
            int b_factor = l - r;
            return b_factor;
        }
        private BNode RotateRR(BNode parent)
        {
            BNode pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            return pivot;
        }
        private BNode RotateLL(BNode parent)
        {
            BNode pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            return pivot;
        }
        private BNode RotateLR(BNode parent)
        {
            BNode pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }
        private BNode RotateRL(BNode parent)
        {
            BNode pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }
    }









}