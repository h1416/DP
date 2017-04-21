using System;

namespace Bridge
{
    class TermPaper : IManuscript
    {
        private IFormatter _formatter;

        public TermPaper(IFormatter formatter)
        {
            _formatter = formatter;
        }

        public string Class { get; set; }
        public string Student { get; set; }
        public string Text { get; set; }
        public string References { get; set; }

        public void Print()
        {
            Console.WriteLine("-TermPaper");
            Console.WriteLine(_formatter.Format("Class", Class));
            Console.WriteLine(_formatter.Format("Student", Student));
            Console.WriteLine(_formatter.Format("Text",Text));
            Console.WriteLine(_formatter.Format("References", References));
            Console.WriteLine();
        }    
    }
}
