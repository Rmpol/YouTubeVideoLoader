using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YouTubeVideoLoader
{
    // Конкретная команда для скачивания видео
    public class DownloadVideoCommand : Command
    {
        public override async Task ExecuteAsync(string videoUrl)
        {
            // В этой команде добавляем возможность отмены операции
            SetCancellationTokenSource();

            var client = new YoutubeClient();
            var videos = client.Videos;

            // Добавляем подпапку к пути
            var outputPath = AppDomain.CurrentDomain.BaseDirectory;

            try
            {
                await videos.DownloadAsync(videoUrl, outputPath, builder => builder.SetPreset(ConversionPreset.UltraFast), cancellationToken: GetCancellationToken());
                Console.WriteLine($"Video downloaded to: {outputPath}");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Download canceled.");
            }
            finally
            {
                // Важно освободить ресурсы, даже если операция была отменена
                Dispose();
            }
        }
    }
}