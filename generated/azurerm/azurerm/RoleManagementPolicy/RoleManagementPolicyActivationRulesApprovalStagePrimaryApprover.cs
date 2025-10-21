using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.roleManagementPolicy.RoleManagementPolicyActivationRulesApprovalStagePrimaryApprover")]
    public class RoleManagementPolicyActivationRulesApprovalStagePrimaryApprover : azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover
    {
        /// <summary>The ID of the object to act as an approver.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#object_id RoleManagementPolicy#object_id}
        /// </remarks>
        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
        public string ObjectId
        {
            get;
            set;
        }

        /// <summary>The type of object acting as an approver.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#type RoleManagementPolicy#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
