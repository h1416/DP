using System;

namespace Bridge
{
    class Book : IManuscript
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public void Print()
        {
            Console.WriteLine("-Book");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Text: {Text}");
            Console.WriteLine();
        }
    }
}
