namespace EmployeeAdmnPortal.Services
{
    public interface ILoggerServices
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(Exception ex, string message);
    }
}
