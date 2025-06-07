using System;

namespace DependencyInjection
{
    public interface IErrorLogger
    {
        void LogMessage(Exception ex);
    }
}
