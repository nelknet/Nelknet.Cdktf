using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mobileNetworkService.MobileNetworkServiceServiceQosPolicyMaximumBitRate")]
    public class MobileNetworkServiceServiceQosPolicyMaximumBitRate : azurerm.MobileNetworkService.IMobileNetworkServiceServiceQosPolicyMaximumBitRate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#downlink MobileNetworkService#downlink}.</summary>
        [JsiiProperty(name: "downlink", typeJson: "{\"primitive\":\"string\"}")]
        public string Downlink
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#uplink MobileNetworkService#uplink}.</summary>
        [JsiiProperty(name: "uplink", typeJson: "{\"primitive\":\"string\"}")]
        public string Uplink
        {
            get;
            set;
        }
    }
}
