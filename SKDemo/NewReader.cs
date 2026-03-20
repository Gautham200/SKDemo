using System.ComponentModel;
using Microsoft.SemanticKernel;
using SimpleFeedReader;

namespace SKDemo;

public class NewReader
{
    [KernelFunction("get_news")]
    [Description("Gets news items for today")]
    [return: Description("A list of news items for today")]
    public async Task<List<FeedItem>> GetNews(Kernel kernel, string category)
    {
        var reader = new FeedReader();
        var feed = await reader.RetrieveFeedAsync($"https://rss.nytimes.com/services/xml/rss/nyt/{category}.xml");
        return feed.Take(5).ToList();
    }
}