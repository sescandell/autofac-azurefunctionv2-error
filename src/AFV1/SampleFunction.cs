using System;
using Autofac;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace AFV1
{
    public static class SampleFunction
    {
        private static readonly ILifetimeScope _rootScope;

        static SampleFunction()
        {
            var builder = new ContainerBuilder();

            _rootScope = builder.Build().BeginLifetimeScope();
        }

        [FunctionName("SampleFunction")]
        public static void Run([TimerTrigger("*/10 * * * * *")]TimerInfo myTimer, TraceWriter log)
        {
            log.Info($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
