using AngleSharp;
using AngleSharp.Io;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        const string WebhookUrl = "";

        static async Task Main(string[] args)
        {
            
            var context = BrowsingContext.New(Configuration.Default
                .WithDefaultLoader(new LoaderOptions { IsResourceLoadingEnabled = true })
                .WithDefaultCookies());
            var doc = await context.OpenAsync("https://www.digitalfoundry.net/");

            var vidoes = doc.QuerySelectorAll("div.video-list div.video").Select(v => new DFVideo
            {
                Title = v.QuerySelector("div.details p.title").TextContent.Trim(),
                PageLink = "https://www.digitalfoundry.net/" + v.QuerySelector("div.details p.title a").Attributes["href"].Value.Trim(),
                Subtitle = v.QuerySelector("div.details p.subtitle").TextContent.Trim(),
            }).ToList();

            if (File.Exists("postedvids.txt"))
            {
                var postedvids = File.ReadAllLines("postedvids.txt");
                var _httpClient = new HttpClient();
                foreach (var vidToPost in vidoes.Where(v => !postedvids.Contains(v.PageLink)))
                {
                    await _httpClient.PostAsJsonAsync(WebhookUrl, new DiscordWebhook
                    {
                        Content = "Digital foundry posted a new video! " + vidToPost.PageLink,
                    }, CancellationToken.None);
                }
            }

            File.WriteAllLines("postedvids.txt", vidoes.Select(v => v.PageLink).ToArray());
        }
    }
}

