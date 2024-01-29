using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YouTubeVideoLoader
{
    public class GetVideoInfoCommand : ICommand
    {
        public async Task ExecuteAsync(string videoUrl)
        {
            var client = new YoutubeClient();
            var video = await client.Videos.GetAsync(videoUrl);

            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Description: {video.Description}");
        }
    }
}
