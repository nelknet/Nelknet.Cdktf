using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetwork
{
    [JsiiInterface(nativeType: typeof(IVirtualNetworkEncryption), fullyQualifiedName: "azurerm.virtualNetwork.VirtualNetworkEncryption")]
    public interface IVirtualNetworkEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#enforcement VirtualNetwork#enforcement}.</summary>
        [JsiiProperty(name: "enforcement", typeJson: "{\"primitive\":\"string\"}")]
        string Enforcement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualNetworkEncryption), fullyQualifiedName: "azurerm.virtualNetwork.VirtualNetworkEncryption")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualNetwork.IVirtualNetworkEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#enforcement VirtualNetwork#enforcement}.</summary>
            [JsiiProperty(name: "enforcement", typeJson: "{\"primitive\":\"string\"}")]
            public string Enforcement
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
