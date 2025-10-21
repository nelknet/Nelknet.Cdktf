using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSynapseWorkspace
{
    [JsiiInterface(nativeType: typeof(IDataAzurermSynapseWorkspaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermSynapseWorkspace.DataAzurermSynapseWorkspaceTimeouts")]
    public interface IDataAzurermSynapseWorkspaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/synapse_workspace#read DataAzurermSynapseWorkspace#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermSynapseWorkspaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermSynapseWorkspace.DataAzurermSynapseWorkspaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermSynapseWorkspace.IDataAzurermSynapseWorkspaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/synapse_workspace#read DataAzurermSynapseWorkspace#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
