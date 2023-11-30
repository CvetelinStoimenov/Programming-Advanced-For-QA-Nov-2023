using System.Security.Cryptography.X509Certificates;

namespace _11._02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string articalDeta = Console.ReadLine();
            string title = articalDeta.Split(", ")[0];
            string content = articalDeta.Split(", ")[1];
            string author = articalDeta.Split(", ")[2];

            Article article = new Article(title, content, author);

            int countCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCommands; i++)
            {
                string[] commandParts = Console.ReadLine().Split(": ");

                string commandName = commandParts[0];
                string commandParameter = commandParts[1];

                switch (commandName)
                {
                    case "Edit":
                        article.Edit(commandParameter);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(commandParameter);
                        break;
                    case "Rename":
                        article.Rename(commandParameter);
                        break;
                }
            }

            //Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            Console.WriteLine(article.ToString());
        }
    }
}