using System;
using System.Collections.Generic;
using System.Linq;

namespace Лабораторна_11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> str = new List<string>()
            {
                 "абвгд",
                 "абвгде",
                 "опрст",
                 "опрсту"
            };
            var lett = (from s in str
                        where (s.Length % 2 == 1)
                        select s[0])
                        .Concat(from s in str
                                where (s.Length % 2 == 0)
                                select s[s.Length - 1])
                        .OrderByDescending(s => (int)s);
            foreach (var l in lett)
            {
                Console.WriteLine(l);
            }
        }
    }
}
