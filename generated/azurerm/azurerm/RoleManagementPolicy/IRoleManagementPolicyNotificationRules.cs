using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IRoleManagementPolicyNotificationRules), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRules")]
    public interface IRoleManagementPolicyNotificationRules
    {
        /// <summary>active_assignments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#active_assignments RoleManagementPolicy#active_assignments}
        /// </remarks>
        [JsiiProperty(name: "activeAssignments", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignments? ActiveAssignments
        {
            get
            {
                return null;
            }
        }

        /// <summary>eligible_activations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#eligible_activations RoleManagementPolicy#eligible_activations}
        /// </remarks>
        [JsiiProperty(name: "eligibleActivations", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivations\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivations? EligibleActivations
        {
            get
            {
                return null;
            }
        }

        /// <summary>eligible_assignments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#eligible_assignments RoleManagementPolicy#eligible_assignments}
        /// </remarks>
        [JsiiProperty(name: "eligibleAssignments", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignments? EligibleAssignments
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoleManagementPolicyNotificationRules), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRules")]
        internal sealed class _Proxy : DeputyBase, azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>active_assignments block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#active_assignments RoleManagementPolicy#active_assignments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activeAssignments", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignments\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignments? ActiveAssignments
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignments?>();
            }

            /// <summary>eligible_activations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#eligible_activations RoleManagementPolicy#eligible_activations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eligibleActivations", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivations\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivations? EligibleActivations
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivations?>();
            }

            /// <summary>eligible_assignments block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#eligible_assignments RoleManagementPolicy#eligible_assignments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eligibleAssignments", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignments\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignments? EligibleAssignments
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignments?>();
            }
        }
    }
}
