using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp11
{
    [ExcludeFromCodeCoverage]
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var printer = new WordPrinter();
            printer.Print("my test");
        }
    }
}
