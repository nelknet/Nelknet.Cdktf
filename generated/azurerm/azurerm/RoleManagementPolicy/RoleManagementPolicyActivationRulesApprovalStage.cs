using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.roleManagementPolicy.RoleManagementPolicyActivationRulesApprovalStage")]
    public class RoleManagementPolicyActivationRulesApprovalStage : azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRulesApprovalStage
    {
        private object _primaryApprover;

        /// <summary>primary_approver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#primary_approver RoleManagementPolicy#primary_approver}
        /// </remarks>
        [JsiiProperty(name: "primaryApprover", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActivationRulesApprovalStagePrimaryApprover\"},\"kind\":\"array\"}}]}}")]
        public object PrimaryApprover
        {
            get => _primaryApprover;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _primaryApprover = value;
            }
        }
    }
}
