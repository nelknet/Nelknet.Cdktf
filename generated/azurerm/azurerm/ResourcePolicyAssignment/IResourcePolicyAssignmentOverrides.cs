using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourcePolicyAssignment
{
    [JsiiInterface(nativeType: typeof(IResourcePolicyAssignmentOverrides), fullyQualifiedName: "azurerm.resourcePolicyAssignment.ResourcePolicyAssignmentOverrides")]
    public interface IResourcePolicyAssignmentOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#value ResourcePolicyAssignment#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>selectors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#selectors ResourcePolicyAssignment#selectors}
        /// </remarks>
        [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourcePolicyAssignment.ResourcePolicyAssignmentOverridesSelectors\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Selectors
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResourcePolicyAssignmentOverrides), fullyQualifiedName: "azurerm.resourcePolicyAssignment.ResourcePolicyAssignmentOverrides")]
        internal sealed class _Proxy : DeputyBase, azurerm.ResourcePolicyAssignment.IResourcePolicyAssignmentOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#value ResourcePolicyAssignment#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>selectors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#selectors ResourcePolicyAssignment#selectors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourcePolicyAssignment.ResourcePolicyAssignmentOverridesSelectors\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Selectors
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
