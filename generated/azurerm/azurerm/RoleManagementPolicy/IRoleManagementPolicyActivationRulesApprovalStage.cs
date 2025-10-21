using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IRoleManagementPolicyActivationRulesApprovalStage), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyActivationRulesApprovalStage")]
    public interface IRoleManagementPolicyActivationRulesApprovalStage
    {
        /// <summary>primary_approver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#primary_approver RoleManagementPolicy#primary_approver}
        /// </remarks>
        [JsiiProperty(name: "primaryApprover", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActivationRulesApprovalStagePrimaryApprover\"},\"kind\":\"array\"}}]}}")]
        object PrimaryApprover
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRoleManagementPolicyActivationRulesApprovalStage), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyActivationRulesApprovalStage")]
        internal sealed class _Proxy : DeputyBase, azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRulesApprovalStage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>primary_approver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#primary_approver RoleManagementPolicy#primary_approver}
            /// </remarks>
            [JsiiProperty(name: "primaryApprover", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActivationRulesApprovalStagePrimaryApprover\"},\"kind\":\"array\"}}]}}")]
            public object PrimaryApprover
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
