using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionPolicyAssignment
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPolicyAssignmentResourceSelectorsSelectors), fullyQualifiedName: "azurerm.subscriptionPolicyAssignment.SubscriptionPolicyAssignmentResourceSelectorsSelectors")]
    public interface ISubscriptionPolicyAssignmentResourceSelectorsSelectors
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#kind SubscriptionPolicyAssignment#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#in SubscriptionPolicyAssignment#in}.</summary>
        [JsiiProperty(name: "in", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? In
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#not_in SubscriptionPolicyAssignment#not_in}.</summary>
        [JsiiProperty(name: "notIn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NotIn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPolicyAssignmentResourceSelectorsSelectors), fullyQualifiedName: "azurerm.subscriptionPolicyAssignment.SubscriptionPolicyAssignmentResourceSelectorsSelectors")]
        internal sealed class _Proxy : DeputyBase, azurerm.SubscriptionPolicyAssignment.ISubscriptionPolicyAssignmentResourceSelectorsSelectors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#kind SubscriptionPolicyAssignment#kind}.</summary>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#in SubscriptionPolicyAssignment#in}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "in", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? In
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#not_in SubscriptionPolicyAssignment#not_in}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notIn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NotIn
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
