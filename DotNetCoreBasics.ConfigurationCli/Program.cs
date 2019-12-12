using Microsoft.Extensions.Configuration;
using System;

namespace DotNetCoreBasics.ConfigurationCli
{
    class Program
    {
        static readonly string[] _keys = new[] { "appName" };
        static readonly string _breakLine = new string('=', 50);
        static IConfiguration _configuration;

        static void Main(string[] args)
        {
            Console.WriteLine("Configuration Demo" + Environment.NewLine);

            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();

            WriteProviderOutput();
            WriteConfigurationOutput();

            Console.WriteLine("Modify the 'appsettings.json' file and press any key to continue.");
            Console.ReadKey();

            WriteProviderOutput();
            WriteConfigurationOutput();
        }

        private static void WriteProviderOutput()
        {
            foreach (var key in _keys)
            {
                Console.WriteLine(_breakLine);
                Console.WriteLine(key + Environment.NewLine);

                foreach (var provider in ((IConfigurationRoot)_configuration).Providers)
                {
                    if (provider.TryGet(key, out string value))
                    {
                        Console.WriteLine($"\tProvider     :{provider.GetType().Name}");
                        Console.WriteLine($"\tValue        :{value}");
                        Console.WriteLine(Environment.NewLine);
                    }
                }
            }
            Console.WriteLine(_breakLine);
        }

        private static void WriteConfigurationOutput()
        {
            Console.WriteLine("Environment Output" + Environment.NewLine);
            foreach (var key in _keys)
            {
                Console.WriteLine($"\t{key}    : {_configuration[key]}");
                Console.WriteLine(Environment.NewLine);
            }
            Console.WriteLine(_breakLine);
        }
    }
}
