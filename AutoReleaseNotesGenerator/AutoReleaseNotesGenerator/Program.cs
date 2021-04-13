using AutoReleaseNotesGenerator.Interfaces;
using AutoReleaseNotesGenerator.Logic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace AutoReleaseNotesGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<ICalc<int>, IntegerCalc>()
                .BuildServiceProvider();

            //configure console logging
            serviceProvider
                .GetService<ILoggerFactory>()
                .AddConsole(LogLevel.Debug);

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();
            logger.LogDebug("Starting application");

            //do the actual work here
            var integer_calculator = serviceProvider.GetService<ICalc<int>>();
            var int_a = 5;
            var int_b = 7;
            Console.WriteLine($"Add {int_a} and {int_b} : {integer_calculator.Add(int_a, int_b)}");
            Console.WriteLine($"Subtract {int_a} and {int_b} : {integer_calculator.Subtract(int_a, int_b)}");
            Console.WriteLine($"Multiple {int_a} and {int_b} : {integer_calculator.Multiply(int_a, int_b)}");
            Console.WriteLine($"Divide {int_a} and {int_b} : {integer_calculator.Divide(int_a, int_b)}");

            logger.LogDebug("All done!");
        }
    }
}
