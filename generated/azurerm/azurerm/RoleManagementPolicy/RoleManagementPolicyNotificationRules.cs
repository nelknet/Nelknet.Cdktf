using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiByValue(fqn: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRules")]
    public class RoleManagementPolicyNotificationRules : azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRules
    {
        /// <summary>active_assignments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#active_assignments RoleManagementPolicy#active_assignments}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activeAssignments", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignments\"}", isOptional: true)]
        public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignments? ActiveAssignments
        {
            get;
            set;
        }

        /// <summary>eligible_activations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#eligible_activations RoleManagementPolicy#eligible_activations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eligibleActivations", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivations\"}", isOptional: true)]
        public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivations? EligibleActivations
        {
            get;
            set;
        }

        /// <summary>eligible_assignments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#eligible_assignments RoleManagementPolicy#eligible_assignments}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eligibleAssignments", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignments\"}", isOptional: true)]
        public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignments? EligibleAssignments
        {
            get;
            set;
        }
    }
}
