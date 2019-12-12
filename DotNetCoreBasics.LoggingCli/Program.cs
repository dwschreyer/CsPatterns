using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace DotNetCoreBasics.LoggingCli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logging Console!");

            //NOTE: Logging in .NET Core is designed to be used with dependency injection.

            //Set up DI
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(_ =>
            {
                //Play around with this setting
                _.SetMinimumLevel(LogLevel.Error);
                _.AddConsole();
                _.AddDebug();
            });
            var services = serviceCollection.BuildServiceProvider();

            //Get the Logger from the DI container.
            var logger = services.GetService<ILogger<Program>>();

            //Do some logging
            logger.LogInformation("This is an information log.");
            logger.LogWarning("This is a warning log.");
            logger.LogCritical("This is a critical log.");

            try
            {
                throw new Exception("The exception!");
            }
            catch (Exception exx)
            {
                logger.LogError(exx, "This is an error log.");
            }

        }
    }
}
