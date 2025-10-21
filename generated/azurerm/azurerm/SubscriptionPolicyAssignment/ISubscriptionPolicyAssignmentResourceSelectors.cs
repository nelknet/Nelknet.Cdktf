using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionPolicyAssignment
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPolicyAssignmentResourceSelectors), fullyQualifiedName: "azurerm.subscriptionPolicyAssignment.SubscriptionPolicyAssignmentResourceSelectors")]
    public interface ISubscriptionPolicyAssignmentResourceSelectors
    {
        /// <summary>selectors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#selectors SubscriptionPolicyAssignment#selectors}
        /// </remarks>
        [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionPolicyAssignment.SubscriptionPolicyAssignmentResourceSelectorsSelectors\"},\"kind\":\"array\"}}]}}")]
        object Selectors
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#name SubscriptionPolicyAssignment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPolicyAssignmentResourceSelectors), fullyQualifiedName: "azurerm.subscriptionPolicyAssignment.SubscriptionPolicyAssignmentResourceSelectors")]
        internal sealed class _Proxy : DeputyBase, azurerm.SubscriptionPolicyAssignment.ISubscriptionPolicyAssignmentResourceSelectors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>selectors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#selectors SubscriptionPolicyAssignment#selectors}
            /// </remarks>
            [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionPolicyAssignment.SubscriptionPolicyAssignmentResourceSelectorsSelectors\"},\"kind\":\"array\"}}]}}")]
            public object Selectors
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#name SubscriptionPolicyAssignment#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
