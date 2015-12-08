using System;

namespace AwesomeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logo = Logo.Draw(Environment.GetEnvironmentVariable("OS"));
            Console.WriteLine(logo);
        }
    }
}
