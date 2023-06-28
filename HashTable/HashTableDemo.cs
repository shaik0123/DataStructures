using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public  class HashTableDemo
    {
        public static void Demo() { 
        Hashtable Ht = new Hashtable();

            Ht.Add(101, "print");
            Ht.Add(102, "output");
            Ht.Add(103, "console");

            foreach (DictionaryEntry i in Ht) 
            {
                Console.WriteLine(i.Key+"---->"+i.Value);
            }


            if (Ht.ContainsKey(102))
            {
                Ht.Remove(102);
            }

            Ht[104] = "added new";

            Console.WriteLine("//////////////////");
            foreach (DictionaryEntry i in Ht)
            {
                Console.WriteLine(i.Key + "---->" + i.Value);
            }

        }

    }
}
