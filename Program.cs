namespace MyConsoleApp

using MyLibrary;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MessageWriter MyWriter = new MessageWriter();
            MyWriter.Writer("HELLO WRITER!");
        }
    }
}