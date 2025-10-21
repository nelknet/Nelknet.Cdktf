using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagementGroupPolicyAssignment
{
    [JsiiInterface(nativeType: typeof(IManagementGroupPolicyAssignmentNonComplianceMessage), fullyQualifiedName: "azurerm.managementGroupPolicyAssignment.ManagementGroupPolicyAssignmentNonComplianceMessage")]
    public interface IManagementGroupPolicyAssignmentNonComplianceMessage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#content ManagementGroupPolicyAssignment#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#policy_definition_reference_id ManagementGroupPolicyAssignment#policy_definition_reference_id}.</summary>
        [JsiiProperty(name: "policyDefinitionReferenceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyDefinitionReferenceId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagementGroupPolicyAssignmentNonComplianceMessage), fullyQualifiedName: "azurerm.managementGroupPolicyAssignment.ManagementGroupPolicyAssignmentNonComplianceMessage")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagementGroupPolicyAssignment.IManagementGroupPolicyAssignmentNonComplianceMessage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#content ManagementGroupPolicyAssignment#content}.</summary>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#policy_definition_reference_id ManagementGroupPolicyAssignment#policy_definition_reference_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyDefinitionReferenceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyDefinitionReferenceId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
