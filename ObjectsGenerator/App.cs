using ObjectsGenerator.Contracts;
using System;
using System.Diagnostics;

namespace ObjectsGenerator
{
    public class App
    {
        private readonly IObjectRequestGenerator objectRequestGenerator;

        public App(IObjectRequestGenerator objectRequestGenerator)
        {
            this.objectRequestGenerator = objectRequestGenerator;
        }

        public void Run()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var objectRequests = objectRequestGenerator.Generate();
            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;
            Console.WriteLine($"{elapsed.Minutes}:{elapsed.Seconds}");

            // TODO: send request
        }
    }
}
