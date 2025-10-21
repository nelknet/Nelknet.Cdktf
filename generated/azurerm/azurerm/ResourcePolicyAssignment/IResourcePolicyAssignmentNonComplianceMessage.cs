using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourcePolicyAssignment
{
    [JsiiInterface(nativeType: typeof(IResourcePolicyAssignmentNonComplianceMessage), fullyQualifiedName: "azurerm.resourcePolicyAssignment.ResourcePolicyAssignmentNonComplianceMessage")]
    public interface IResourcePolicyAssignmentNonComplianceMessage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#content ResourcePolicyAssignment#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#policy_definition_reference_id ResourcePolicyAssignment#policy_definition_reference_id}.</summary>
        [JsiiProperty(name: "policyDefinitionReferenceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyDefinitionReferenceId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResourcePolicyAssignmentNonComplianceMessage), fullyQualifiedName: "azurerm.resourcePolicyAssignment.ResourcePolicyAssignmentNonComplianceMessage")]
        internal sealed class _Proxy : DeputyBase, azurerm.ResourcePolicyAssignment.IResourcePolicyAssignmentNonComplianceMessage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#content ResourcePolicyAssignment#content}.</summary>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#policy_definition_reference_id ResourcePolicyAssignment#policy_definition_reference_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyDefinitionReferenceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyDefinitionReferenceId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
