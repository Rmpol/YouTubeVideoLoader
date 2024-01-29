using YouTubeVideoLoader;

class Program
{
    static async Task Main(string[] args)
    {
        var getInfoCommand = new GetVideoInfoCommand();
        var downloadCommand = new DownloadVideoCommand();

        var invoker = new VideoInvoker(getInfoCommand, downloadCommand);

        Console.WriteLine("Enter the YouTube video URL:");
        var videoUrl = Console.ReadLine();

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Get Video Info");
        Console.WriteLine("2. Download Video");

        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                await invoker.GetVideoInfo(videoUrl);
                break;
            case "2":
                await invoker.DownloadVideo(videoUrl);
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }
}