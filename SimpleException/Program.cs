using System;

namespace SimpleException
{
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Simple exception application";
            var car = new Car("Honda", 20);
            car.RadioTune(true);
            try
            {
                for (var i = 0; i < 10; i++)
                    car.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Source: {e.Source}");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Data: {e.Data}");
                Console.WriteLine($"Stack Trace: {e.StackTrace}");
                Console.WriteLine($"Target Site: {e.TargetSite}, Attributes: {e.TargetSite.Attributes}, Calling Convention: {e.TargetSite.CallingConvention} \n" +
                                  $"MethodHandle: {e.TargetSite.MethodHandle}, Name: {e.TargetSite.Name}");
                Console.WriteLine($"Help link: {e.HelpLink}");
                Console.WriteLine(e.InnerException);
            }
            Console.ReadLine();
        }
    }
}
