using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourcePolicyAssignment
{
    [JsiiInterface(nativeType: typeof(IResourcePolicyAssignmentResourceSelectors), fullyQualifiedName: "azurerm.resourcePolicyAssignment.ResourcePolicyAssignmentResourceSelectors")]
    public interface IResourcePolicyAssignmentResourceSelectors
    {
        /// <summary>selectors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#selectors ResourcePolicyAssignment#selectors}
        /// </remarks>
        [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourcePolicyAssignment.ResourcePolicyAssignmentResourceSelectorsSelectors\"},\"kind\":\"array\"}}]}}")]
        object Selectors
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#name ResourcePolicyAssignment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResourcePolicyAssignmentResourceSelectors), fullyQualifiedName: "azurerm.resourcePolicyAssignment.ResourcePolicyAssignmentResourceSelectors")]
        internal sealed class _Proxy : DeputyBase, azurerm.ResourcePolicyAssignment.IResourcePolicyAssignmentResourceSelectors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>selectors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#selectors ResourcePolicyAssignment#selectors}
            /// </remarks>
            [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourcePolicyAssignment.ResourcePolicyAssignmentResourceSelectorsSelectors\"},\"kind\":\"array\"}}]}}")]
            public object Selectors
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#name ResourcePolicyAssignment#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
