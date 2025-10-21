using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetwork
{
    [JsiiInterface(nativeType: typeof(IVirtualNetworkSubnetDelegation), fullyQualifiedName: "azurerm.virtualNetwork.VirtualNetworkSubnetDelegation")]
    public interface IVirtualNetworkSubnetDelegation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#name VirtualNetwork#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#service_delegation VirtualNetwork#service_delegation}.</summary>
        [JsiiProperty(name: "serviceDelegation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualNetwork.VirtualNetworkSubnetDelegationServiceDelegation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ServiceDelegation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualNetworkSubnetDelegation), fullyQualifiedName: "azurerm.virtualNetwork.VirtualNetworkSubnetDelegation")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualNetwork.IVirtualNetworkSubnetDelegation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#name VirtualNetwork#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#service_delegation VirtualNetwork#service_delegation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceDelegation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualNetwork.VirtualNetworkSubnetDelegationServiceDelegation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ServiceDelegation
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
