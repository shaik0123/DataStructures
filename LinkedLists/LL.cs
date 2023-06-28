using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LinkedLists
{
    public  class LL
    {
        /* public Node head;

         public void AddFirst(int data)
         {
             Node node = new Node(data);
             if (this.head == null )
             {
                 this.head = node;
             }
             else
             {
                 Node temp = head;
                 while (temp.next != null) 
                 {
                     temp = temp.next;

                 }
                 temp.next = node;
             }
             Console.WriteLine(node.data);

         }
         public void AddLast(int data) 
         {
             Node node = new Node(data);
             if (this.head == null ) 
             {
                 this.head = node;
             }
             Console.WriteLine(node.data);

         }
         public void LastNode()
         {
             Node temp = head;
             while (temp.next != null) 
             {
                 temp = temp.next;

             }
             Console.WriteLine(temp);

         }*/

        public Node head;
        private int Size;
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null) 
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Size++;

        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Size++;
        }
        public void AddLast(int data) 
        {
            Node newNode = new Node(data);
            if (head == null) 
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Size++;
        }
        public void DeleteFirst()
        {
            if(head == null)
            {
                Console.WriteLine("list is empty");
            }
            else 
            {
                head = head.next;
            }
            Size--;

        }
        public void DeleteLast() 
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else if(head.next == null)
            {
                head = null;
            }
            else
            {
                Node secondLast = head;
                Node lastNode = head.next;
                while(lastNode.next != null)
                {
                    lastNode = lastNode.next;
                    secondLast = secondLast.next;

                }
                secondLast.next = null;
            }
            Size--;

        }
        public int ListSize()
        {
            return Size;
        }
        /* public void InsertAtIndex(int index, int node)
         {
             if (index == 0)
             {
                 AddFirst(node);
                 return;
             }
             if (index == Size)
             {
                 AddLast(node);
                 return;
             }
             Node newNode = new Node(node);
             Node temp = head;
             int i = 0;
             while(i < index ) 
             {
                 temp = temp.next;
                 i++;

             }
             temp.next = newNode;
             Size++;

         }*/
        public Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }

        public void OutPut() 
        {
            Node temp = head;
            if (temp == null) 
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                while (temp != null) 
                {
                    Console.Write (temp.data + "-->");
                    temp = temp.next;
                }
                Console.WriteLine(" ");
               // Console.WriteLine(temp.data);
            }

        }
    }

}
