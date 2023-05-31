using NLog;

namespace MarsQA.Utils
{
    public static class LoggerManager
    {
        public static Logger Logger { get; } = LogManager.GetCurrentClassLogger();
    }

}
