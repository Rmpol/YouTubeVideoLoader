using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeVideoLoader
{
    public class VideoInvoker
    {
        private ICommand _getInfoCommand;
        private ICommand _downloadCommand;

        public VideoInvoker(ICommand getInfoCommand, ICommand downloadCommand)
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
