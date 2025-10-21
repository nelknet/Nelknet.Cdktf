using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IRoleManagementPolicyActivationRules), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyActivationRules")]
    public interface IRoleManagementPolicyActivationRules
    {
        /// <summary>approval_stage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#approval_stage RoleManagementPolicy#approval_stage}
        /// </remarks>
        [JsiiProperty(name: "approvalStage", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActivationRulesApprovalStage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRulesApprovalStage? ApprovalStage
        {
            get
            {
                return null;
            }
        }

        /// <summary>The time after which the an activation can be valid for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#maximum_duration RoleManagementPolicy#maximum_duration}
        /// </remarks>
        [JsiiProperty(name: "maximumDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether an approval is required for activation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#require_approval RoleManagementPolicy#require_approval}
        /// </remarks>
        [JsiiProperty(name: "requireApproval", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireApproval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether a conditional access context is required during activation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#required_conditional_access_authentication_context RoleManagementPolicy#required_conditional_access_authentication_context}
        /// </remarks>
        [JsiiProperty(name: "requiredConditionalAccessAuthenticationContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequiredConditionalAccessAuthenticationContext
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether a justification is required during activation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#require_justification RoleManagementPolicy#require_justification}
        /// </remarks>
        [JsiiProperty(name: "requireJustification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireJustification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether multi-factor authentication is required during activation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#require_multifactor_authentication RoleManagementPolicy#require_multifactor_authentication}
        /// </remarks>
        [JsiiProperty(name: "requireMultifactorAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireMultifactorAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether ticket information is required during activation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#require_ticket_info RoleManagementPolicy#require_ticket_info}
        /// </remarks>
        [JsiiProperty(name: "requireTicketInfo", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireTicketInfo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoleManagementPolicyActivationRules), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyActivationRules")]
        internal sealed class _Proxy : DeputyBase, azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>approval_stage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#approval_stage RoleManagementPolicy#approval_stage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "approvalStage", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActivationRulesApprovalStage\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRulesApprovalStage? ApprovalStage
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRulesApprovalStage?>();
            }

            /// <summary>The time after which the an activation can be valid for.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#maximum_duration RoleManagementPolicy#maximum_duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximumDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether an approval is required for activation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#require_approval RoleManagementPolicy#require_approval}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireApproval", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireApproval
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether a conditional access context is required during activation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#required_conditional_access_authentication_context RoleManagementPolicy#required_conditional_access_authentication_context}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requiredConditionalAccessAuthenticationContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequiredConditionalAccessAuthenticationContext
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether a justification is required during activation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#require_justification RoleManagementPolicy#require_justification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireJustification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireJustification
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether multi-factor authentication is required during activation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#require_multifactor_authentication RoleManagementPolicy#require_multifactor_authentication}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireMultifactorAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireMultifactorAuthentication
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether ticket information is required during activation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#require_ticket_info RoleManagementPolicy#require_ticket_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireTicketInfo", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireTicketInfo
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
