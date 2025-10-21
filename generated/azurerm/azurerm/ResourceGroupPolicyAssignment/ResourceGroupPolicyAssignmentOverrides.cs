using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceGroupPolicyAssignment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentOverrides")]
    public class ResourceGroupPolicyAssignmentOverrides : azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#value ResourceGroupPolicyAssignment#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        private object? _selectors;

        /// <summary>selectors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#selectors ResourceGroupPolicyAssignment#selectors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentOverridesSelectors\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Selectors
        {
            get => _selectors;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentOverridesSelectors[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentOverridesSelectors).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _selectors = value;
            }
        }
    }
}
