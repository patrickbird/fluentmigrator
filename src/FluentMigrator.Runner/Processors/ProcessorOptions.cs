using System.Collections.Generic;

namespace FluentMigrator.Runner.Processors
{
    public class ProcessorOptions : IMigrationProcessorOptions
    {
        public bool PreviewOnly { get; set; }
        public int Timeout { get; set; }
        public IDictionary<string, string> ProviderSwitches { get; set; }
    }
}