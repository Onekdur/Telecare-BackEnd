using Serilog;
using Serilog.Events;
using Telecare.Domain.Logger;

namespace Telecare.Application.Logger
{
    public class LoggerManager : ILogggerManager
    {
        public void LogDebug(string massage)
        {
            Log.Write(LogEventLevel.Debug,massage);
        }

        public void LogError(string massage)
        {
            Log.Write(LogEventLevel.Error, massage);
        }

        public void LogInfo(string massage)
        {
            Log.Write(LogEventLevel.Information, massage);
        }

        public void LogWrn(string massage)
        {
            Log.Write(LogEventLevel.Warning, massage);
        }
    }
}
