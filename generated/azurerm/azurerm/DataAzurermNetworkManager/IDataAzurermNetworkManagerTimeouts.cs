using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetworkManager
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetworkManagerTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetworkManager.DataAzurermNetworkManagerTimeouts")]
    public interface IDataAzurermNetworkManagerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager#read DataAzurermNetworkManager#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetworkManagerTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetworkManager.DataAzurermNetworkManagerTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetworkManager.IDataAzurermNetworkManagerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager#read DataAzurermNetworkManager#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
