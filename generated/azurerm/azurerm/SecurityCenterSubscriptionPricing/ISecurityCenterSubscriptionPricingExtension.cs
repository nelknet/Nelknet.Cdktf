using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SecurityCenterSubscriptionPricing
{
    [JsiiInterface(nativeType: typeof(ISecurityCenterSubscriptionPricingExtension), fullyQualifiedName: "azurerm.securityCenterSubscriptionPricing.SecurityCenterSubscriptionPricingExtension")]
    public interface ISecurityCenterSubscriptionPricingExtension
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_subscription_pricing#name SecurityCenterSubscriptionPricing#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_subscription_pricing#additional_extension_properties SecurityCenterSubscriptionPricing#additional_extension_properties}.</summary>
        [JsiiProperty(name: "additionalExtensionProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AdditionalExtensionProperties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityCenterSubscriptionPricingExtension), fullyQualifiedName: "azurerm.securityCenterSubscriptionPricing.SecurityCenterSubscriptionPricingExtension")]
        internal sealed class _Proxy : DeputyBase, azurerm.SecurityCenterSubscriptionPricing.ISecurityCenterSubscriptionPricingExtension
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_subscription_pricing#name SecurityCenterSubscriptionPricing#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_subscription_pricing#additional_extension_properties SecurityCenterSubscriptionPricing#additional_extension_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalExtensionProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AdditionalExtensionProperties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
