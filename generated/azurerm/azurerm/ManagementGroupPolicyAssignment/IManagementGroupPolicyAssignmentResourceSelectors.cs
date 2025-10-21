using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagementGroupPolicyAssignment
{
    [JsiiInterface(nativeType: typeof(IManagementGroupPolicyAssignmentResourceSelectors), fullyQualifiedName: "azurerm.managementGroupPolicyAssignment.ManagementGroupPolicyAssignmentResourceSelectors")]
    public interface IManagementGroupPolicyAssignmentResourceSelectors
    {
        /// <summary>selectors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#selectors ManagementGroupPolicyAssignment#selectors}
        /// </remarks>
        [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managementGroupPolicyAssignment.ManagementGroupPolicyAssignmentResourceSelectorsSelectors\"},\"kind\":\"array\"}}]}}")]
        object Selectors
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#name ManagementGroupPolicyAssignment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagementGroupPolicyAssignmentResourceSelectors), fullyQualifiedName: "azurerm.managementGroupPolicyAssignment.ManagementGroupPolicyAssignmentResourceSelectors")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagementGroupPolicyAssignment.IManagementGroupPolicyAssignmentResourceSelectors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>selectors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#selectors ManagementGroupPolicyAssignment#selectors}
            /// </remarks>
            [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managementGroupPolicyAssignment.ManagementGroupPolicyAssignmentResourceSelectorsSelectors\"},\"kind\":\"array\"}}]}}")]
            public object Selectors
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#name ManagementGroupPolicyAssignment#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
