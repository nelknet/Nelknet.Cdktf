using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualHubConnection
{
    [JsiiInterface(nativeType: typeof(IDataAzurermVirtualHubConnectionTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionTimeouts")]
    public interface IDataAzurermVirtualHubConnectionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_connection#read DataAzurermVirtualHubConnection#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermVirtualHubConnectionTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermVirtualHubConnection.IDataAzurermVirtualHubConnectionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_connection#read DataAzurermVirtualHubConnection#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
