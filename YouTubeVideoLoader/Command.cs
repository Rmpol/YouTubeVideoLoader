
namespace YouTubeVideoLoader
{
    // Абстрактный класс команды
    public abstract class Command : IDisposable
    {
        private CancellationTokenSource _cancellationTokenSource;

        // Метод выполнения операции
        public abstract Task ExecuteAsync(string videoUrl);

        // Метод отмены операции
        public void Cancel()
        {
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
            }
        }

        // Защищенный метод для установки токена отмены
        protected void SetCancellationTokenSource()
        {
            _cancellationTokenSource = new CancellationTokenSource();
        }

        // Защищенный метод для получения токена отмены
        protected CancellationToken GetCancellationToken()
        {
            return _cancellationTokenSource?.Token ?? CancellationToken.None;
        }

        // Метод для освобождения ресурсов
        public void Dispose()
        {
            _cancellationTokenSource?.Dispose();
        }
    }
}