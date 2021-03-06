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
            // Setup D.I.
            IServiceProvider serviceProvider = ConfigureIoC();

            // Configure Console Logging
            ConfigureLogging(serviceProvider);
            ILogger<Program> logger = CreateLoggingInstance(serviceProvider);

            logger.LogDebug("Starting application");

            logger.LogDebug("Starting Integer Calculator");
            RunIntegerCalculator(serviceProvider);
            logger.LogDebug("Integer Calculator Complete");

            logger.LogDebug("Starting Double Calculator");
            RunDoubleCalculator(serviceProvider);
            logger.LogDebug("Double Calculator Complete");

            logger.LogDebug("All done!");
        }

        private static void RunIntegerCalculator(IServiceProvider serviceProvider)
        {
            var integer_calculator = serviceProvider.GetService<ICalc<int>>();
            var int_a = 5;
            var int_b = 7;
            Console.WriteLine($"Add {int_a} and {int_b} : {integer_calculator.Add(int_a, int_b)}");
            Console.WriteLine($"Subtract {int_a} and {int_b} : {integer_calculator.Subtract(int_a, int_b)}");
            Console.WriteLine($"Multiple {int_a} and {int_b} : {integer_calculator.Multiply(int_a, int_b)}");
            Console.WriteLine($"Divide {int_a} and {int_b} : {integer_calculator.Divide(int_a, int_b)}");
        }

        private static void RunDoubleCalculator(IServiceProvider serviceProvider)
        {
            var double_calculator = serviceProvider.GetService<ICalc<double>>();
            var int_a = 5.3;
            var int_b = 7.8;
            Console.WriteLine($"Add {int_a} and {int_b} : {double_calculator.Add(int_a, int_b)}");
            Console.WriteLine($"Subtract {int_a} and {int_b} : {double_calculator.Subtract(int_a, int_b)}");
            Console.WriteLine($"Multiple {int_a} and {int_b} : {double_calculator.Multiply(int_a, int_b)}");
            Console.WriteLine($"Divide {int_a} and {int_b} : {double_calculator.Divide(int_a, int_b)}");
        }

        private static ILogger<Program> CreateLoggingInstance(IServiceProvider serviceProvider)
        {
            return serviceProvider.GetService<ILoggerFactory>()
                            .CreateLogger<Program>();
        }

        private static void ConfigureLogging(IServiceProvider serviceProvider)
        {
            serviceProvider
                            .GetService<ILoggerFactory>()
                            .AddConsole(LogLevel.Debug);
        }

        private static IServiceProvider ConfigureIoC()
        {
            return new ServiceCollection()
                .AddLogging()
                .AddSingleton<ICalc<int>, IntegerCalc>()
                .AddSingleton<ICalc<double>, DoubleCalc>()
                .BuildServiceProvider();
        }
    }
}