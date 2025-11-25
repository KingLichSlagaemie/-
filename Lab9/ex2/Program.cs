using HtmlAgilityPack;

namespace ex2
{
    internal class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Enter the URL: ");
            string? url = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(url))
            {
                try
                {
                    HttpClient client = new HttpClient();
                    string html = await client.GetStringAsync(url);
                    HtmlDocument doc = new HtmlDocument();
                    doc.LoadHtml(html);
                    var titleNode = doc.DocumentNode.SelectSingleNode("//title");
                    if (titleNode != null)
                    {
                        Console.WriteLine($"Заголовок сттаницы {titleNode.InnerText}");

                    }
                    else
                    {
                        Console.WriteLine("Нет заголовка");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("url is emty");
            }
        }
    }
}
