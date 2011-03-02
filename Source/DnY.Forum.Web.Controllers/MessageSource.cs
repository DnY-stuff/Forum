namespace DnY.Forum.Web.Controllers
{
    using System.Collections.Generic;

    public static class MessageSource
    {
        private static readonly Dictionary<string, string> _messages;

        static MessageSource()
        {
            _messages = new Dictionary<string, string>();
        }

        public static string GetMessage(string key, object[] args, string defaultMsg)
        {
            string msgValue;
            _messages.TryGetValue(key, out msgValue);

            if (string.IsNullOrEmpty(msgValue))
            {
                return defaultMsg;
            }

            if (args == null)
            {
                return msgValue;
            }

            return string.Format(msgValue, args);
        }

        public static string GetMessage(string key, object[] args)
        {
            return string.Format(_messages[key], args);
        }

        public static string GetMessage(string key)
        {
            return string.Format(_messages[key]);
        }
    }
}