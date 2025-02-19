using NLog;

namespace S7.Helper
{
    public class HLog
    {
        private static NLog.Logger logger = LogManager.GetLogger("HLog");
        public static void Debug(string msg)
        {
            logger.Debug(msg);
        }

        public static void Info(string msg)
        {
            logger.Info(msg);
        }

        public static void Error(string msg, Exception ex = null)
        {
            var errMsg = ex != null ? $"{msg}{Environment.NewLine}{PackExceptionMessage(ex)}" : msg;
            logger.Error(errMsg, ex);
        }


        private static string PackExceptionMessage(Exception ex)
        {
            var message = $"-->Message:{ex.Message}{Environment.NewLine}-->StackTrace:{Environment.NewLine}{ex.StackTrace}";

            if (ex.InnerException == null)
            {
                return message;
            }
            else
            {
                return $"{message}{Environment.NewLine}-->InnerException:{Environment.NewLine}{PackExceptionMessage(ex.InnerException)}";
            }
        }
    }
}
