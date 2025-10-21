using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSynapseWorkspace
{
    [JsiiByValue(fqn: "azurerm.dataAzurermSynapseWorkspace.DataAzurermSynapseWorkspaceTimeouts")]
    public class DataAzurermSynapseWorkspaceTimeouts : azurerm.DataAzurermSynapseWorkspace.IDataAzurermSynapseWorkspaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/synapse_workspace#read DataAzurermSynapseWorkspace#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
