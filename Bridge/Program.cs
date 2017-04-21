using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var faq = new FAQ { Title = "The Bridge Pattern FAQ" };
            faq.Questions.Add("What is it?", "A design pattern.");
            faq.Questions.Add("When do we use it?", "When you need to separte an abstraction from an implementation.");
            faq.Print();

            var book = new Book
            {
                Title = "Lots of Patterns",
                Author = "John Sonmez",
                Text = "Blah blah blah..."
            };
            book.Print();

            var paper = new TermPaper
            {
                Class = "Design Patterns",
                Student = "Joe N00b",
                Text = "Blah blah blah...",
                References = "GOF"
            };
            paper.Print();

            Console.ReadLine();
        }
    }
}
