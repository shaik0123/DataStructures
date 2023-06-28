using System;

namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree tree = new BinaryTree();
            tree.Insert(40);
            tree.Insert(20);
            tree.Insert(30);
            tree.Insert(10);

            tree.Output();
        }
    }
}
