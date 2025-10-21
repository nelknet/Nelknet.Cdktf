using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiByValue(fqn: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignments")]
    public class RoleManagementPolicyNotificationRulesEligibleAssignments : azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignments
    {
        /// <summary>admin_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#admin_notifications RoleManagementPolicy#admin_notifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications\"}", isOptional: true)]
        public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications? AdminNotifications
        {
            get;
            set;
        }

        /// <summary>approver_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#approver_notifications RoleManagementPolicy#approver_notifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications\"}", isOptional: true)]
        public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications? ApproverNotifications
        {
            get;
            set;
        }

        /// <summary>assignee_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#assignee_notifications RoleManagementPolicy#assignee_notifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications\"}", isOptional: true)]
        public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications? AssigneeNotifications
        {
            get;
            set;
        }
    }
}
