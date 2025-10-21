using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiByValue(fqn: "azurerm.roleManagementPolicy.RoleManagementPolicyEligibleAssignmentRules")]
    public class RoleManagementPolicyEligibleAssignmentRules : azurerm.RoleManagementPolicy.IRoleManagementPolicyEligibleAssignmentRules
    {
        private object? _expirationRequired;

        /// <summary>Must the assignment have an expiry date.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#expiration_required RoleManagementPolicy#expiration_required}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expirationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ExpirationRequired
        {
            get => _expirationRequired;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _expirationRequired = value;
            }
        }

        /// <summary>The duration after which assignments expire.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#expire_after RoleManagementPolicy#expire_after}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expireAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExpireAfter
        {
            get;
            set;
        }
    }
}
