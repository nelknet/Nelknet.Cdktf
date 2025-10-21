using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagementGroupPolicyAssignment
{
    [JsiiInterface(nativeType: typeof(IManagementGroupPolicyAssignmentIdentity), fullyQualifiedName: "azurerm.managementGroupPolicyAssignment.ManagementGroupPolicyAssignmentIdentity")]
    public interface IManagementGroupPolicyAssignmentIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#type ManagementGroupPolicyAssignment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#identity_ids ManagementGroupPolicyAssignment#identity_ids}.</summary>
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IdentityIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagementGroupPolicyAssignmentIdentity), fullyQualifiedName: "azurerm.managementGroupPolicyAssignment.ManagementGroupPolicyAssignmentIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagementGroupPolicyAssignment.IManagementGroupPolicyAssignmentIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#type ManagementGroupPolicyAssignment#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#identity_ids ManagementGroupPolicyAssignment#identity_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IdentityIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
