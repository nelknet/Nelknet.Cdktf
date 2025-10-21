using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorOrigin
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorOrigin.CdnFrontdoorOriginPrivateLink")]
    public class CdnFrontdoorOriginPrivateLink : azurerm.CdnFrontdoorOrigin.ICdnFrontdoorOriginPrivateLink
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#location CdnFrontdoorOrigin#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public string Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#private_link_target_id CdnFrontdoorOrigin#private_link_target_id}.</summary>
        [JsiiProperty(name: "privateLinkTargetId", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateLinkTargetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#request_message CdnFrontdoorOrigin#request_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequestMessage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#target_type CdnFrontdoorOrigin#target_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetType
        {
            get;
            set;
        }
    }
}
