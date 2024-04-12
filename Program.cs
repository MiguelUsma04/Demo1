namespace MyConsoleApp

using MyLibrary;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MessageWriter MyWriter = new MessageWriter();
            MyWriter.Write("HELLO, WRITER!");

            FiggleWriter FWriter = new FiggleWriter();
            FWriter.Write("Hello, Figgle!!!");
        }
    }
}