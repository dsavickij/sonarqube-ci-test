using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
