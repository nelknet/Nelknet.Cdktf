using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IRoleManagementPolicyNotificationRulesEligibleActivations), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivations")]
    public interface IRoleManagementPolicyNotificationRulesEligibleActivations
    {
        /// <summary>admin_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#admin_notifications RoleManagementPolicy#admin_notifications}
        /// </remarks>
        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications? AdminNotifications
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
        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications? ApproverNotifications
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
        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications? AssigneeNotifications
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoleManagementPolicyNotificationRulesEligibleActivations), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivations")]
        internal sealed class _Proxy : DeputyBase, azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>admin_notifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#admin_notifications RoleManagementPolicy#admin_notifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications? AdminNotifications
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications?>();
            }

            /// <summary>approver_notifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#approver_notifications RoleManagementPolicy#approver_notifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications? ApproverNotifications
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications?>();
            }

            /// <summary>assignee_notifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#assignee_notifications RoleManagementPolicy#assignee_notifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications? AssigneeNotifications
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications?>();
            }
        }
    }
}
