using System;

namespace Bridge
{
    class Book : IManuscript
    {
        private IFormatter _formatter;

        public Book(IFormatter formatter)
        {
            _formatter = formatter;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public void Print()
        {
            Console.WriteLine("-Book");
            Console.WriteLine(_formatter.Format("Title", Title));
            Console.WriteLine(_formatter.Format("Author", Author));
            Console.WriteLine(_formatter.Format("Text", Text));
            Console.WriteLine();
        }
    }
}
