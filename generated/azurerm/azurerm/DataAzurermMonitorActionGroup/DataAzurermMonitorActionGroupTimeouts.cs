using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMonitorActionGroup
{
    [JsiiByValue(fqn: "azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupTimeouts")]
    public class DataAzurermMonitorActionGroupTimeouts : azurerm.DataAzurermMonitorActionGroup.IDataAzurermMonitorActionGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_action_group#read DataAzurermMonitorActionGroup#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
