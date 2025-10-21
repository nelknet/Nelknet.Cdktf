using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDedicatedHost
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDedicatedHost.DataAzurermDedicatedHostTimeouts")]
    public class DataAzurermDedicatedHostTimeouts : azurerm.DataAzurermDedicatedHost.IDataAzurermDedicatedHostTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dedicated_host#read DataAzurermDedicatedHost#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
