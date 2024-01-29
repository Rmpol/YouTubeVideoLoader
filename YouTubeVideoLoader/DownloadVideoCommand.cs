using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YouTubeVideoLoader
{
    public class DownloadVideoCommand : ICommand
    {
        public async Task ExecuteAsync(string videoUrl)
        {
            var client = new YoutubeClient();
            var videos = client.Videos;
            var outputPath = "downloaded_video.mp4";

            await videos.DownloadAsync(videoUrl, outputPath, builder => builder.SetPreset(ConversionPreset.UltraFast));

            Console.WriteLine($"Video downloaded to: {outputPath}");
        }
    }
}
