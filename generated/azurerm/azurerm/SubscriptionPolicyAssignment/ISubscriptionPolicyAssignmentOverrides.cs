using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionPolicyAssignment
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPolicyAssignmentOverrides), fullyQualifiedName: "azurerm.subscriptionPolicyAssignment.SubscriptionPolicyAssignmentOverrides")]
    public interface ISubscriptionPolicyAssignmentOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#value SubscriptionPolicyAssignment#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>selectors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#selectors SubscriptionPolicyAssignment#selectors}
        /// </remarks>
        [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionPolicyAssignment.SubscriptionPolicyAssignmentOverridesSelectors\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Selectors
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPolicyAssignmentOverrides), fullyQualifiedName: "azurerm.subscriptionPolicyAssignment.SubscriptionPolicyAssignmentOverrides")]
        internal sealed class _Proxy : DeputyBase, azurerm.SubscriptionPolicyAssignment.ISubscriptionPolicyAssignmentOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#value SubscriptionPolicyAssignment#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>selectors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#selectors SubscriptionPolicyAssignment#selectors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionPolicyAssignment.SubscriptionPolicyAssignmentOverridesSelectors\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Selectors
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
