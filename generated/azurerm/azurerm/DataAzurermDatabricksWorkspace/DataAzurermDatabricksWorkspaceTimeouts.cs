using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDatabricksWorkspace
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDatabricksWorkspace.DataAzurermDatabricksWorkspaceTimeouts")]
    public class DataAzurermDatabricksWorkspaceTimeouts : azurerm.DataAzurermDatabricksWorkspace.IDataAzurermDatabricksWorkspaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_workspace#read DataAzurermDatabricksWorkspace#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
