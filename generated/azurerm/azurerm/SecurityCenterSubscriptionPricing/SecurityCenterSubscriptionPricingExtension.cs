using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SecurityCenterSubscriptionPricing
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.securityCenterSubscriptionPricing.SecurityCenterSubscriptionPricingExtension")]
    public class SecurityCenterSubscriptionPricingExtension : azurerm.SecurityCenterSubscriptionPricing.ISecurityCenterSubscriptionPricingExtension
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_subscription_pricing#name SecurityCenterSubscriptionPricing#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_subscription_pricing#additional_extension_properties SecurityCenterSubscriptionPricing#additional_extension_properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalExtensionProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? AdditionalExtensionProperties
        {
            get;
            set;
        }
    }
}
