using System.Collections.Generic;

namespace FluentMigrator
{
    public interface IMigrationProcessorOptions
    {
        bool PreviewOnly { get; }
        int Timeout { get; }
        IDictionary<string, string> ProviderSwitches { get; }
    }
}