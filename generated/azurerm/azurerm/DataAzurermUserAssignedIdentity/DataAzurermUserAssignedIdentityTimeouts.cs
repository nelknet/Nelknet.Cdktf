using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermUserAssignedIdentity
{
    [JsiiByValue(fqn: "azurerm.dataAzurermUserAssignedIdentity.DataAzurermUserAssignedIdentityTimeouts")]
    public class DataAzurermUserAssignedIdentityTimeouts : azurerm.DataAzurermUserAssignedIdentity.IDataAzurermUserAssignedIdentityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/user_assigned_identity#read DataAzurermUserAssignedIdentity#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
