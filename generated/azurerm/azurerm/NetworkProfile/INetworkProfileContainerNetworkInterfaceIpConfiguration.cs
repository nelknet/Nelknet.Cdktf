using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkProfile
{
    [JsiiInterface(nativeType: typeof(INetworkProfileContainerNetworkInterfaceIpConfiguration), fullyQualifiedName: "azurerm.networkProfile.NetworkProfileContainerNetworkInterfaceIpConfiguration")]
    public interface INetworkProfileContainerNetworkInterfaceIpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#name NetworkProfile#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#subnet_id NetworkProfile#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkProfileContainerNetworkInterfaceIpConfiguration), fullyQualifiedName: "azurerm.networkProfile.NetworkProfileContainerNetworkInterfaceIpConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkProfile.INetworkProfileContainerNetworkInterfaceIpConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#name NetworkProfile#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#subnet_id NetworkProfile#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
