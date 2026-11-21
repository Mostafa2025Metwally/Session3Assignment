using System.Drawing;
using System.Text;

namespace SessionOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //________________________________________________________________________
            //Q1
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);

            //________________________________________________________________________
            //Q2
            string str1 = "Clean Code";
            string str2 = "Clean Code";
            bool areSame = ReferenceEquals(str1, str2);
            Console.WriteLine($"Do str1 and str2 point to the same object? {areSame}");

            //________________________________________________________________________
            //Q3

            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            Console.WriteLine(sb.ToString());

            //________________________________________________________________________
            //Q4

            sb.Replace("Book List", "Library");
            Console.WriteLine(sb.ToString());

            //________________________________________________________________________
            //Q5

            string title2 = "Clean Code";
            int pages = 464;
            string sentence = "Book: " + title2 + ", Pages: " + pages;
            Console.WriteLine(sentence);

            //________________________________________________________________________
            //Q6

            string sentence2 = $"Book: {title2}, Pages: {pages}";

            //________________________________________________________________________
            //Q7

            string sentence3 = string.Format("Book: {0}, Pages: {1}", title2, pages);

            //________________________________________________________________________
            //Q8

            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }

        }
    }
}