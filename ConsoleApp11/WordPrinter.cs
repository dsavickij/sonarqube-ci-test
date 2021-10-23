using System;

namespace ConsoleApp11
{
    public class WordPrinter
    {
        public bool Print(string words)
        {
            var time = DateTime.Now;
            Console.WriteLine(words + time);

            return true;
        }
    }
}
