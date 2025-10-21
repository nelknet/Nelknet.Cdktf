using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiByValue(fqn: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivations")]
    public class RoleManagementPolicyNotificationRulesEligibleActivations : azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivations
    {
        /// <summary>admin_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#admin_notifications RoleManagementPolicy#admin_notifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications\"}", isOptional: true)]
        public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications? AdminNotifications
        {
            get;
            set;
        }

        /// <summary>approver_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#approver_notifications RoleManagementPolicy#approver_notifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications\"}", isOptional: true)]
        public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications? ApproverNotifications
        {
            get;
            set;
        }

        /// <summary>assignee_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#assignee_notifications RoleManagementPolicy#assignee_notifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications\"}", isOptional: true)]
        public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications? AssigneeNotifications
        {
            get;
            set;
        }
    }
}
