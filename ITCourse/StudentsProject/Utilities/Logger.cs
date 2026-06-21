using System;

namespace ITCourse.StudentsProject.Utilities
{
    public class Logger : IDisposable
    {
        private bool _disposed = false;
        private readonly string _sessionName;

        public Logger(string sessionName)
        {
            _sessionName = sessionName;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"[LOG] Session Started: {_sessionName} — {DateTime.Now:HH:mm:ss}");
            Console.ResetColor();
        }

        public void Log(string message)
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(Logger));

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss} — {message}");
            Console.ResetColor();
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"[LOG] Session Ended: {_sessionName} — {DateTime.Now:HH:mm:ss}");
                Console.ResetColor();
                _disposed = true;
            }
        }
    }
}