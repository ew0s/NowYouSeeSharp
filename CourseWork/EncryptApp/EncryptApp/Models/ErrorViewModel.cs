namespace EncryptApp.Models
{
    public class ErrorViewModel
    {
        public ErrorViewModel(string requestId)
        {
            RequestId = requestId;
        }

        public string RequestId { get; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}