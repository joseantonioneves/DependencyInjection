using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationEvent objOperationEvent = new OperationEvent(new EventViewerLogger());
            objOperationEvent.Division();
            Console.Read();
        }
    }
}
