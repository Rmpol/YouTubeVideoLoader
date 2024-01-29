
namespace YouTubeVideoLoader
{
    // Класс Invoker
    public class VideoInvoker
    {
        private Command _getInfoCommand;
        private Command _downloadCommand;

        public VideoInvoker(Command getInfoCommand, Command downloadCommand)
        {
            _getInfoCommand = getInfoCommand;
            _downloadCommand = downloadCommand;
        }

        public async Task GetVideoInfo(string videoUrl)
        {
            await _getInfoCommand.ExecuteAsync(videoUrl);
        }

        public async Task DownloadVideo(string videoUrl)
        {
            await _downloadCommand.ExecuteAsync(videoUrl);
        }
    }
}