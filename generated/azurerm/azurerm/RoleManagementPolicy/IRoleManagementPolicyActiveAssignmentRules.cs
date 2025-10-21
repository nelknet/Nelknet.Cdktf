using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IRoleManagementPolicyActiveAssignmentRules), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyActiveAssignmentRules")]
    public interface IRoleManagementPolicyActiveAssignmentRules
    {
        /// <summary>Must the assignment have an expiry date.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#expiration_required RoleManagementPolicy#expiration_required}
        /// </remarks>
        [JsiiProperty(name: "expirationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExpirationRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>The duration after which assignments expire.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#expire_after RoleManagementPolicy#expire_after}
        /// </remarks>
        [JsiiProperty(name: "expireAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpireAfter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether a justification is required to make an assignment.</summary>
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

        /// <summary>Whether multi-factor authentication is required to make an assignment.</summary>
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

        /// <summary>Whether ticket information is required to make an assignment.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IRoleManagementPolicyActiveAssignmentRules), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyActiveAssignmentRules")]
        internal sealed class _Proxy : DeputyBase, azurerm.RoleManagementPolicy.IRoleManagementPolicyActiveAssignmentRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Must the assignment have an expiry date.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#expiration_required RoleManagementPolicy#expiration_required}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expirationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ExpirationRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The duration after which assignments expire.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#expire_after RoleManagementPolicy#expire_after}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expireAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpireAfter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether a justification is required to make an assignment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#require_justification RoleManagementPolicy#require_justification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireJustification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireJustification
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether multi-factor authentication is required to make an assignment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#require_multifactor_authentication RoleManagementPolicy#require_multifactor_authentication}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireMultifactorAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireMultifactorAuthentication
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether ticket information is required to make an assignment.</summary>
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
