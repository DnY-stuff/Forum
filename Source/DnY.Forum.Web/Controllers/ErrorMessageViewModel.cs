namespace DnY.Forum.Web.Controllers
{
    public class ErrorMessageViewModel
    {
        private readonly string _message;

        public ErrorMessageViewModel(string message)
        {
            _message = message;
        }

        public string Message
        {
            get { return _message; }
        }
    }
}