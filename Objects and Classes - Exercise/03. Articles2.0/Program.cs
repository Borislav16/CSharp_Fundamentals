using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Authors = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Authors { get; set; }


        public override string ToString()
        {
            return $"{Title} - {Content}: {Authors}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int index = int.Parse(Console.ReadLine());

            for (int i = 0; i < index; i++)
            {
                string[] articleStr = Console.ReadLine().Split(", ").ToArray();

                Article article = new Article(articleStr[0], articleStr[1], articleStr[2]);

                articles.Add(article);
            }
            foreach (Article art in articles )
            {
                Console.WriteLine(art.ToString());
            }

        }
    }
}
