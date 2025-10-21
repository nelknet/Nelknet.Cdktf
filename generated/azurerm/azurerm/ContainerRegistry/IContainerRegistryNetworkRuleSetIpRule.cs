using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistry
{
    [JsiiInterface(nativeType: typeof(IContainerRegistryNetworkRuleSetIpRule), fullyQualifiedName: "azurerm.containerRegistry.ContainerRegistryNetworkRuleSetIpRule")]
    public interface IContainerRegistryNetworkRuleSetIpRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#action ContainerRegistry#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#ip_range ContainerRegistry#ip_range}.</summary>
        [JsiiProperty(name: "ipRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpRange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerRegistryNetworkRuleSetIpRule), fullyQualifiedName: "azurerm.containerRegistry.ContainerRegistryNetworkRuleSetIpRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerRegistry.IContainerRegistryNetworkRuleSetIpRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#action ContainerRegistry#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#ip_range ContainerRegistry#ip_range}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpRange
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
