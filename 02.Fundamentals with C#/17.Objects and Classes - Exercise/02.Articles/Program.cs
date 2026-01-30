namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleStr = Console.ReadLine().Split(", ");

            Article article = new Article(articleStr[0], articleStr[1], articleStr[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                articleStr = Console.ReadLine().Split(": ");

                switch (articleStr[0])
                {
                    case "Edit":
                        article.EditContent(articleStr[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(articleStr[1]);
                        break;
                    case "Rename":
                        article.Rename(articleStr[1]);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(article);
            
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void EditContent(string newContent) 
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor) 
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle) 
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
