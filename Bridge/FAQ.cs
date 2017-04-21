using System;
using System.Collections.Generic;

namespace Bridge
{
    class FAQ
    {
        public string Title { get; set; }
        public Dictionary<string, string> Questions { get; set; }

        public FAQ()
        {
            Questions = new Dictionary<string, string>();
        }

        public void Print()
        {
            Console.WriteLine("-FAQ");
            Console.WriteLine($"Title: {Title}");

            foreach (var q in Questions)
            {
                Console.WriteLine($"Question: {q.Key}");
                Console.WriteLine($"Answer: {q.Value}");
            }

            Console.WriteLine();
        }
    }
}
