using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Frontdoor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.frontdoor.FrontdoorBackendPoolLoadBalancing")]
    public class FrontdoorBackendPoolLoadBalancing : azurerm.Frontdoor.IFrontdoorBackendPoolLoadBalancing
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#name Frontdoor#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#additional_latency_milliseconds Frontdoor#additional_latency_milliseconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalLatencyMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AdditionalLatencyMilliseconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#sample_size Frontdoor#sample_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sampleSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SampleSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#successful_samples_required Frontdoor#successful_samples_required}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "successfulSamplesRequired", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SuccessfulSamplesRequired
        {
            get;
            set;
        }
    }
}
