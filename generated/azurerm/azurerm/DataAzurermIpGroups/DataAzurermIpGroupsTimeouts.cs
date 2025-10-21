using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermIpGroups
{
    [JsiiByValue(fqn: "azurerm.dataAzurermIpGroups.DataAzurermIpGroupsTimeouts")]
    public class DataAzurermIpGroupsTimeouts : azurerm.DataAzurermIpGroups.IDataAzurermIpGroupsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ip_groups#read DataAzurermIpGroups#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
