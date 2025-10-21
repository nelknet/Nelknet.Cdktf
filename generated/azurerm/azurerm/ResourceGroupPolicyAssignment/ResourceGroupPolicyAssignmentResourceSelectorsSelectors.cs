using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceGroupPolicyAssignment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentResourceSelectorsSelectors")]
    public class ResourceGroupPolicyAssignmentResourceSelectorsSelectors : azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentResourceSelectorsSelectors
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#kind ResourceGroupPolicyAssignment#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#in ResourceGroupPolicyAssignment#in}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "in", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? In
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#not_in ResourceGroupPolicyAssignment#not_in}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notIn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotIn
        {
            get;
            set;
        }
    }
}
