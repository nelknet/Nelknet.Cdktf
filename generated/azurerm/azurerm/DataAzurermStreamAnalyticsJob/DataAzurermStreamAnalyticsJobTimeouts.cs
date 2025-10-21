using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStreamAnalyticsJob
{
    [JsiiByValue(fqn: "azurerm.dataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobTimeouts")]
    public class DataAzurermStreamAnalyticsJobTimeouts : azurerm.DataAzurermStreamAnalyticsJob.IDataAzurermStreamAnalyticsJobTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stream_analytics_job#read DataAzurermStreamAnalyticsJob#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
