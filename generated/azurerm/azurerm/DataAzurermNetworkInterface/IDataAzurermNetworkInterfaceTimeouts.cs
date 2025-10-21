using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetworkInterface
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetworkInterfaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetworkInterface.DataAzurermNetworkInterfaceTimeouts")]
    public interface IDataAzurermNetworkInterfaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_interface#read DataAzurermNetworkInterface#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetworkInterfaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetworkInterface.DataAzurermNetworkInterfaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetworkInterface.IDataAzurermNetworkInterfaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_interface#read DataAzurermNetworkInterface#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
