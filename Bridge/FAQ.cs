using System;
using System.Collections.Generic;

namespace Bridge
{
    class FAQ : IManuscript
    {
        private IFormatter _formatter;

        public string Title { get; set; }
        public Dictionary<string, string> Questions { get; set; }

        public FAQ(IFormatter formatter)
        {
            _formatter = formatter;
            Questions = new Dictionary<string, string>();
        }

        public void Print()
        {
            Console.WriteLine("-FAQ");
            Console.WriteLine(_formatter.Format("Title", Title));

            foreach (var q in Questions)
            {
                Console.WriteLine(_formatter.Format("Question", q.Key));
                Console.WriteLine(_formatter.Format("Answer", q.Value));
            }

            Console.WriteLine();
        }
    }
}
