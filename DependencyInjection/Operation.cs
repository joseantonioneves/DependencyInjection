using System;

namespace DependencyInjection
{
   public class Operation
    {
       IErrorLogger logger = new FileLogger();
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
