using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules), fullyQualifiedName: "azurerm.batchPool.BatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules")]
    public interface IBatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#access BatchPool#access}.</summary>
        [JsiiProperty(name: "access", typeJson: "{\"primitive\":\"string\"}")]
        string Access
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#priority BatchPool#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#source_address_prefix BatchPool#source_address_prefix}.</summary>
        [JsiiProperty(name: "sourceAddressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        string SourceAddressPrefix
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#source_port_ranges BatchPool#source_port_ranges}.</summary>
        [JsiiProperty(name: "sourcePortRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SourcePortRanges
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules), fullyQualifiedName: "azurerm.batchPool.BatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#access BatchPool#access}.</summary>
            [JsiiProperty(name: "access", typeJson: "{\"primitive\":\"string\"}")]
            public string Access
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#priority BatchPool#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#source_address_prefix BatchPool#source_address_prefix}.</summary>
            [JsiiProperty(name: "sourceAddressPrefix", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceAddressPrefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#source_port_ranges BatchPool#source_port_ranges}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourcePortRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SourcePortRanges
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
