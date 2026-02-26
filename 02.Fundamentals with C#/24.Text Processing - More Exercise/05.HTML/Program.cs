using System;
using System.Collections.Generic;
using System.Text;

namespace MorseCodeHTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Четем заглавието
            string title = Console.ReadLine();

            // Четем съдържанието
            string content = Console.ReadLine();

            // Четем коментарите до "end of comments"
            List<string> comments = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "end of comments")
            {
                comments.Add(input);
            }

            // Извеждане на HTML със красиви отстъпи
            Console.WriteLine("<h1>");
            Console.WriteLine("    " + title);
            Console.WriteLine("</h1>");

            Console.WriteLine("<article>");
            Console.WriteLine("    " + content);
            Console.WriteLine("</article>");

            foreach (var comment in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine("    " + comment);
                Console.WriteLine("</div>");
            }
        }
    }
}