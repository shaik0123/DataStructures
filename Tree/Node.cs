using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public  class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public Node(int data) 
        {
            this.Data = data;
        }
    }
}
