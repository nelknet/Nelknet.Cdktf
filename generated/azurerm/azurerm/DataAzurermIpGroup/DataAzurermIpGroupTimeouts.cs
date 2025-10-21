using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermIpGroup
{
    [JsiiByValue(fqn: "azurerm.dataAzurermIpGroup.DataAzurermIpGroupTimeouts")]
    public class DataAzurermIpGroupTimeouts : azurerm.DataAzurermIpGroup.IDataAzurermIpGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ip_group#read DataAzurermIpGroup#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
