using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDatabricksWorkspacePrivateEndpointConnection
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDatabricksWorkspacePrivateEndpointConnectionTimeouts), fullyQualifiedName: "azurerm.dataAzurermDatabricksWorkspacePrivateEndpointConnection.DataAzurermDatabricksWorkspacePrivateEndpointConnectionTimeouts")]
    public interface IDataAzurermDatabricksWorkspacePrivateEndpointConnectionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_workspace_private_endpoint_connection#read DataAzurermDatabricksWorkspacePrivateEndpointConnection#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDatabricksWorkspacePrivateEndpointConnectionTimeouts), fullyQualifiedName: "azurerm.dataAzurermDatabricksWorkspacePrivateEndpointConnection.DataAzurermDatabricksWorkspacePrivateEndpointConnectionTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDatabricksWorkspacePrivateEndpointConnection.IDataAzurermDatabricksWorkspacePrivateEndpointConnectionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_workspace_private_endpoint_connection#read DataAzurermDatabricksWorkspacePrivateEndpointConnection#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
