using System;

namespace AwesomeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logo = Logo.Draw(EnvironmentHelpers.OSName);
            Console.WriteLine(logo);
        }
    }
}
