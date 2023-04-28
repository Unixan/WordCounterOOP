namespace WordCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var counter = new Counter(@"C:\Users\Ståle\source\repos\WordCounter\WordCounter\Text.txt");
            counter.CountChars();
            counter.CountLines();
            counter.CountWords();
        }
    }
}