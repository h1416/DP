using System;

namespace Bridge
{
    class TermPaper
    {
        public string Class { get; set; }
        public string Student { get; set; }
        public string Text { get; set; }
        public string References { get; set; }

        public void Print()
        {
            Console.WriteLine("-TermPaper");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Student: {Student}");
            Console.WriteLine($"Text: {Text}");
            Console.WriteLine($"References: {References}");
            Console.WriteLine();
        }    
    }
}
