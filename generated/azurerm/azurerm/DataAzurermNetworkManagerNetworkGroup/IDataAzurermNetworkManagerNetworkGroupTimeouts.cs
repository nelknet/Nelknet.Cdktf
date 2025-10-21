using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetworkManagerNetworkGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetworkManagerNetworkGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetworkManagerNetworkGroup.DataAzurermNetworkManagerNetworkGroupTimeouts")]
    public interface IDataAzurermNetworkManagerNetworkGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager_network_group#read DataAzurermNetworkManagerNetworkGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetworkManagerNetworkGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetworkManagerNetworkGroup.DataAzurermNetworkManagerNetworkGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetworkManagerNetworkGroup.IDataAzurermNetworkManagerNetworkGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager_network_group#read DataAzurermNetworkManagerNetworkGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
