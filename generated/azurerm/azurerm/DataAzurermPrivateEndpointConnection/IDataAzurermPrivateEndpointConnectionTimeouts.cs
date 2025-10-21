using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateEndpointConnection
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPrivateEndpointConnectionTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateEndpointConnection.DataAzurermPrivateEndpointConnectionTimeouts")]
    public interface IDataAzurermPrivateEndpointConnectionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_endpoint_connection#read DataAzurermPrivateEndpointConnection#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPrivateEndpointConnectionTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateEndpointConnection.DataAzurermPrivateEndpointConnectionTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPrivateEndpointConnection.IDataAzurermPrivateEndpointConnectionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_endpoint_connection#read DataAzurermPrivateEndpointConnection#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
