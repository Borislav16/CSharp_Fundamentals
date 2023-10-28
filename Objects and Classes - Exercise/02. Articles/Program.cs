using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace _02._Articles
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
        
        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Authors = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Authors}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleStr = Console.ReadLine().Split(", ").ToArray();

            Article article = new Article(articleStr[0], articleStr[1], articleStr[2]);

            int index = int.Parse(Console.ReadLine());
            for (int i = 0; i < index; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                switch(command[0])
                {
                    case "Edit":
                        string newContent = command[1];
                        article.Edit(newContent);
                        break;
                    case "ChangeAuthor":
                        string newAuthor = command[1];
                        article.ChangeAuthor(newAuthor);
                        break;
                    case "Rename":
                        string newTitle = command[1];
                        article.Rename(newTitle);
                        break;


                }
            }
            Console.WriteLine(article);
            
        }
    }
}
