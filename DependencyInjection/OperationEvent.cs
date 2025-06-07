using System;

namespace DependencyInjection
{
    public class OperationEvent
    {
        IErrorLogger logger;

        public OperationEvent(IErrorLogger logger)
        {
            this.logger = logger;
        }

        public void Division()
        {
            try
            {
                int firstNumber = 15, secondNumber = 0, result;
                result = firstNumber / secondNumber;
                Console.WriteLine("Resultado é :{0}", result);
            }
            catch (DivideByZeroException ex)
            {
                logger.LogMessage(ex);
            }
        }
    }
}
