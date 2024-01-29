using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YouTubeVideoLoader
{
    // Конкретная команда для получения информации о видео
    public class GetVideoInfoCommand : Command
    {
        public override async Task ExecuteAsync(string videoUrl)
        {
            // Допустим, в этой команде нет необходимости отмены операции
            var client = new YoutubeClient();
            var video = await client.Videos.GetAsync(videoUrl);

            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Description: {video.Description}");
        }
    }
}