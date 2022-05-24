using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Лабораторна_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var simya = new List<string> { "Мама", "Папа", "Дедушка", "Бабушка", "Я"};
            ArrayList array_list = new ArrayList(simya);
            LinkedList<string> linked_list = new LinkedList<string>(simya);
            SortedSet<string> sorted_set = new SortedSet<string>(simya);
            HashSet<string> hash_set = new HashSet<string>(simya);
            Stopwatch for_array = new Stopwatch();
            Stopwatch for_linked = new Stopwatch();
            Stopwatch for_sorted = new Stopwatch();
            Stopwatch for_hash = new Stopwatch();
            Console.Write("Додавання - 1, пошук - 2, видалення -3: ");
            int i = int.Parse(Console.ReadLine());
            if (i==1)
            {
                while (true)
                {
                    Console.Write("Додати: ");
                    string q = Console.ReadLine();
                    for_array.Start();
                    array_list.Add(q);
                    for_array.Stop();
                    for_linked.Start();
                    linked_list.AddLast(q);
                    for_linked.Stop();
                    for_sorted.Start();
                    sorted_set.Add(q);
                    for_sorted.Stop();
                    for_hash.Start();
                    hash_set.Add(q);
                    for_hash.Stop();
                    if (q=="-1")
                    {
                        break;
                    }
                }
                Console.WriteLine("Для ArrayList: " + for_array.ElapsedTicks);
                Console.WriteLine("Для LinkedList: " + for_linked.ElapsedTicks);
                Console.WriteLine("Для SortedSet: " + for_sorted.ElapsedTicks);
                Console.WriteLine("Для HashSet: " + for_hash.ElapsedTicks);
            }
            else if (i==2)
            {
                Console.Write("Знайти: ");
                string q = Console.ReadLine();
                for_array.Start();
                array_list.Contains(q);
                for_array.Stop();
                for_linked.Start();
                linked_list.Contains(q);
                for_linked.Stop();
                for_sorted.Start();
                sorted_set.Contains(q);
                for_sorted.Stop();
                for_hash.Start();
                hash_set.Contains(q);
                for_hash.Stop();
                Console.WriteLine("Для ArrayList: " + for_array.ElapsedTicks);
                Console.WriteLine("Для LinkedList: " + for_linked.ElapsedTicks);
                Console.WriteLine("Для SortedSet: " + for_sorted.ElapsedTicks);
                Console.WriteLine("Для HashSet: " + for_hash.ElapsedTicks);
            }
            else if (i == 3)
            {
                Console.Write("Видалити: ");
                string q = Console.ReadLine();
                for_array.Start();
                array_list.Remove(q);
                for_array.Stop();
                for_linked.Start();
                linked_list.Remove(q);
                for_linked.Stop();
                for_sorted.Start();
                sorted_set.Remove(q);
                for_sorted.Stop();
                for_hash.Start();
                hash_set.Remove(q);
                for_hash.Stop();
                Console.WriteLine("Для ArrayList: " + for_array.ElapsedTicks);
                Console.WriteLine("Для LinkedList: " + for_linked.ElapsedTicks);
                Console.WriteLine("Для SortedSet: " + for_sorted.ElapsedTicks);
                Console.WriteLine("Для HashSet: " + for_hash.ElapsedTicks);
            }
        }
    }
}
