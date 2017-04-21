using System;
using System.Collections.Generic;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var documents = new List<IManuscript>();
            var formatter = new StandardFormatter();

            var faq = new FAQ (formatter) { Title = "The Bridge Pattern FAQ" };
            faq.Questions.Add("What is it?", "A design pattern.");
            faq.Questions.Add("When do we use it?", "When you need to separte an abstraction from an implementation.");
            documents.Add(faq);

            var book = new Book (formatter)
            {
                Title = "Lots of Patterns",
                Author = "John Sonmez",
                Text = "Blah blah blah..."
            };
            documents.Add(book);

            var paper = new TermPaper (formatter)
            {
                Class = "Design Patterns",
                Student = "Joe N00b",
                Text = "Blah blah blah...",
                References = "GOF"
            };
            documents.Add(paper);

            documents.ForEach(doc => doc.Print());

            Console.ReadLine();
        }
    }
}
