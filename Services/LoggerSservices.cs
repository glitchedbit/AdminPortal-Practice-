using Serilog;

namespace EmployeeAdmnPortal.Services
{

    public class LoggerServices : ILoggerServices
    {
        public void LogInfo(string message)
        {
            Log.Information(message);
        }

        public void LogWarning(string message)
        {
            Log.Warning(message);
        }

        public void LogError(Exception ex, string message)
        {
            Log.Error(ex, message);
        }
    }
}
