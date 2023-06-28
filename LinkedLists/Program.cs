using System;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LL lL = new LL();
            lL.Add(2);
            lL.Add(3);
            lL.Add(4);
            lL.AddFirst(5);
            //lL.AddFirst(6);
            lL.AddLast(7);
           // lL.DeleteFirst();
            //lL.DeleteLast(); 
            lL.InsertAtParticularPosition(3, 1);
            lL.AddFirst(6);
            lL.OutPut();
            //lL.AddLast(3);
            Console.WriteLine("list size is : " + lL.ListSize());
        }
    }
}
