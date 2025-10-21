using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkProfile
{
    [JsiiInterface(nativeType: typeof(INetworkProfileContainerNetworkInterface), fullyQualifiedName: "azurerm.networkProfile.NetworkProfileContainerNetworkInterface")]
    public interface INetworkProfileContainerNetworkInterface
    {
        /// <summary>ip_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#ip_configuration NetworkProfile#ip_configuration}
        /// </remarks>
        [JsiiProperty(name: "ipConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.networkProfile.NetworkProfileContainerNetworkInterfaceIpConfiguration\"},\"kind\":\"array\"}}]}}")]
        object IpConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#name NetworkProfile#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkProfileContainerNetworkInterface), fullyQualifiedName: "azurerm.networkProfile.NetworkProfileContainerNetworkInterface")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkProfile.INetworkProfileContainerNetworkInterface
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ip_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#ip_configuration NetworkProfile#ip_configuration}
            /// </remarks>
            [JsiiProperty(name: "ipConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.networkProfile.NetworkProfileContainerNetworkInterfaceIpConfiguration\"},\"kind\":\"array\"}}]}}")]
            public object IpConfiguration
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#name NetworkProfile#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
