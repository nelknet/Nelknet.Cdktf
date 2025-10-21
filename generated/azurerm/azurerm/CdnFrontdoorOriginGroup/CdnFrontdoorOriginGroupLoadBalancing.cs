using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorOriginGroup
{
    [JsiiByValue(fqn: "azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupLoadBalancing")]
    public class CdnFrontdoorOriginGroupLoadBalancing : azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupLoadBalancing
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group#additional_latency_in_milliseconds CdnFrontdoorOriginGroup#additional_latency_in_milliseconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalLatencyInMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AdditionalLatencyInMilliseconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group#sample_size CdnFrontdoorOriginGroup#sample_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sampleSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SampleSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group#successful_samples_required CdnFrontdoorOriginGroup#successful_samples_required}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "successfulSamplesRequired", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SuccessfulSamplesRequired
        {
            get;
            set;
        }
    }
}
