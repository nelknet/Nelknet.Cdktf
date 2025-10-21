using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NewRelicMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.newRelicMonitor.NewRelicMonitorIdentity")]
    public class NewRelicMonitorIdentity : azurerm.NewRelicMonitor.INewRelicMonitorIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#type NewRelicMonitor#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
