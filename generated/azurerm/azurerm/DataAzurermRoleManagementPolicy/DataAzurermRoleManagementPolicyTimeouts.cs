using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermRoleManagementPolicy
{
    [JsiiByValue(fqn: "azurerm.dataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyTimeouts")]
    public class DataAzurermRoleManagementPolicyTimeouts : azurerm.DataAzurermRoleManagementPolicy.IDataAzurermRoleManagementPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/role_management_policy#read DataAzurermRoleManagementPolicy#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
