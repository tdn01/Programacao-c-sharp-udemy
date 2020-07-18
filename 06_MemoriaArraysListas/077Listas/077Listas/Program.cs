﻿using System;
using System.Collections.Generic;

namespace _077Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            list.Insert(2, "Marco");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            Console.WriteLine("List count: " + list.Count);

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("first 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);            

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            List<string> list2 = list.FindAll(x => x.Length == 5);          
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            list.Remove("Alex");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            //list.RemoveAt(3);
            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            //list.RemoveRange(2, 2);
            //foreach(string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            Console.WriteLine();
        }
    }
}
