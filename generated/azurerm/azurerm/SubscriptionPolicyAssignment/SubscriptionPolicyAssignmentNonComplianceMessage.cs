using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionPolicyAssignment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.subscriptionPolicyAssignment.SubscriptionPolicyAssignmentNonComplianceMessage")]
    public class SubscriptionPolicyAssignmentNonComplianceMessage : azurerm.SubscriptionPolicyAssignment.ISubscriptionPolicyAssignmentNonComplianceMessage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#content SubscriptionPolicyAssignment#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#policy_definition_reference_id SubscriptionPolicyAssignment#policy_definition_reference_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyDefinitionReferenceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PolicyDefinitionReferenceId
        {
            get;
            set;
        }
    }
}
