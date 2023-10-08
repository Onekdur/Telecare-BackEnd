namespace Telecare.Domain.Logger
{
    public interface ILogggerManager
    {
        void LogInfo(string massage);
        void LogWrn(string massage);
        void LogDebug(string massage);
        void LogError(string massage);
    }
}