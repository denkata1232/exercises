using System.Text;

namespace unicode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*open for ideas*/
            string word = Console.ReadLine();
            UnicodeEncoding unicodeResult = new UnicodeEncoding();
            Decoder i = unicodeResult.GetDecoder();
            Console.WriteLine();
        }
    }
}