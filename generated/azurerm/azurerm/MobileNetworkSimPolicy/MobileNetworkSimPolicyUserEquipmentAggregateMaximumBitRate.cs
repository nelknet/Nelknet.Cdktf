using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkSimPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRate")]
    public class MobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRate : azurerm.MobileNetworkSimPolicy.IMobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#downlink MobileNetworkSimPolicy#downlink}.</summary>
        [JsiiProperty(name: "downlink", typeJson: "{\"primitive\":\"string\"}")]
        public string Downlink
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#uplink MobileNetworkSimPolicy#uplink}.</summary>
        [JsiiProperty(name: "uplink", typeJson: "{\"primitive\":\"string\"}")]
        public string Uplink
        {
            get;
            set;
        }
    }
}
