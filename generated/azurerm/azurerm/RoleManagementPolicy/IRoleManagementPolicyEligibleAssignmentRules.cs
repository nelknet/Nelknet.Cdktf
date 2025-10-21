using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IRoleManagementPolicyEligibleAssignmentRules), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyEligibleAssignmentRules")]
    public interface IRoleManagementPolicyEligibleAssignmentRules
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

        [JsiiTypeProxy(nativeType: typeof(IRoleManagementPolicyEligibleAssignmentRules), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyEligibleAssignmentRules")]
        internal sealed class _Proxy : DeputyBase, azurerm.RoleManagementPolicy.IRoleManagementPolicyEligibleAssignmentRules
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
        }
    }
}
