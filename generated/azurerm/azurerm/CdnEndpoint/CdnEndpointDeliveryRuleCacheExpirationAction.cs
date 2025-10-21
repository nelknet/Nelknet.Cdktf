using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCacheExpirationAction")]
    public class CdnEndpointDeliveryRuleCacheExpirationAction : azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheExpirationAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#behavior CdnEndpoint#behavior}.</summary>
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
        public string Behavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#duration CdnEndpoint#duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Duration
        {
            get;
            set;
        }
    }
}
