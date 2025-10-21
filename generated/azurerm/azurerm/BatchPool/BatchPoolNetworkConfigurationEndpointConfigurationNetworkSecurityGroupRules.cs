using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules")]
    public class BatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules : azurerm.BatchPool.IBatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#access BatchPool#access}.</summary>
        [JsiiProperty(name: "access", typeJson: "{\"primitive\":\"string\"}")]
        public string Access
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#priority BatchPool#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public double Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#source_address_prefix BatchPool#source_address_prefix}.</summary>
        [JsiiProperty(name: "sourceAddressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceAddressPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#source_port_ranges BatchPool#source_port_ranges}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SourcePortRanges
        {
            get;
            set;
        }
    }
}
