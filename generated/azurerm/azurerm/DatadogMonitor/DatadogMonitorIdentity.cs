using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DatadogMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.datadogMonitor.DatadogMonitorIdentity")]
    public class DatadogMonitorIdentity : azurerm.DatadogMonitor.IDatadogMonitorIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#type DatadogMonitor#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
