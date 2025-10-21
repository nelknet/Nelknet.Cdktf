using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IRoleManagementPolicyNotificationRulesEligibleAssignments), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignments")]
    public interface IRoleManagementPolicyNotificationRulesEligibleAssignments
    {
        /// <summary>admin_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#admin_notifications RoleManagementPolicy#admin_notifications}
        /// </remarks>
        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications? AdminNotifications
        {
            get
            {
                return null;
            }
        }

        /// <summary>approver_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#approver_notifications RoleManagementPolicy#approver_notifications}
        /// </remarks>
        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications? ApproverNotifications
        {
            get
            {
                return null;
            }
        }

        /// <summary>assignee_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#assignee_notifications RoleManagementPolicy#assignee_notifications}
        /// </remarks>
        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications? AssigneeNotifications
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoleManagementPolicyNotificationRulesEligibleAssignments), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignments")]
        internal sealed class _Proxy : DeputyBase, azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>admin_notifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#admin_notifications RoleManagementPolicy#admin_notifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications? AdminNotifications
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications?>();
            }

            /// <summary>approver_notifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#approver_notifications RoleManagementPolicy#approver_notifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications? ApproverNotifications
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications?>();
            }

            /// <summary>assignee_notifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#assignee_notifications RoleManagementPolicy#assignee_notifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications? AssigneeNotifications
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications?>();
            }
        }
    }
}
