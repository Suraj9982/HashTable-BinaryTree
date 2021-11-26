using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashAndBinary
{
    class BinarySearchTree
    {
        static readonly int COUNT = 10;
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void Insert(int value)
        {
            Node newnode = new Node(value);
            newnode.data = value;
            if (root == null)
            {
                root = newnode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (value < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newnode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newnode;
                            break;
                        }
                    }
                }
            }
        }
        public void Pre_order(Node parent)
        {
            if (parent != null)
            {
                Console.WriteLine(parent.data + " ");
                Pre_order(parent.left);
                Pre_order(parent.right);
            }
        }
        public void Post_order(Node parent)
        {
            if (parent != null)
            {
                Post_order(parent.left);
                Post_order(parent.right);
                Console.WriteLine(parent.data + " ");
            }
        }
        public void In_order(Node parent)
        {
            if (parent != null)
            {
                In_order(parent.left);
                Console.WriteLine(parent.data + " ");
                In_order(parent.right);
            }
        }
        public static void Print2Dtree(Node root,int space)
        {
            if (root == null)
                return;
            space += COUNT;
            Print2Dtree(root.right, space);
            for (int i = COUNT; i < space; i++)
            {
                Console.Write(" ");
            }
                Console.WriteLine(root.data + "\n"); 
            Print2Dtree(root.left, space);
        }
        public static bool search(Node root,int value)
        {
            if (root == null)
            {
                return false;
            }
            if (root.data == value)
            {
                return true;
            }
            bool result1 = search(root.left, value);
            if (result1)
            {
                return true;
            }
            else
            {
                bool result2 = search(root.right, value);
                return result2;
            }
        }

    }
}
