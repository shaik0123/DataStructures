using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public  class BinaryTree
    {
        Node root;
        public BinaryTree()
        {
            root = null;
        }
        public void Insert(int data) 
        {
            if (root == null) 
            {
                root = new Node(data);
            }
            InsertData(root, new Node(data));
        }
        public void InsertData(Node root,Node newNode) 
        {
            if (root == null) 
            {
                root = newNode;
            }
            if (newNode.Data < root.Data)
            {
                if(root.Left == null) 
                {
                    root.Left = newNode;
                }
                else
                {
                    InsertData(root.Left, newNode);
                }
            }
            else
            {
                if (newNode.Right == null)
                {
                    root.Right = newNode;
                }
                else
                {
                    InsertData(root.Right, newNode);
                }
            }
            
        }
        public void Output()
        {
            display(root);
        }
        void display(Node root)
        {
            if (root == null)
            { 
                return; 
            }
            display(root.Left);
            Console.WriteLine($"{root.Data}  ");
            display(root.Right);

           
        }
    }

}
