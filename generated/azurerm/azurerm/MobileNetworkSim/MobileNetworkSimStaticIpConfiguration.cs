using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkSim
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mobileNetworkSim.MobileNetworkSimStaticIpConfiguration")]
    public class MobileNetworkSimStaticIpConfiguration : azurerm.MobileNetworkSim.IMobileNetworkSimStaticIpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim#attached_data_network_id MobileNetworkSim#attached_data_network_id}.</summary>
        [JsiiProperty(name: "attachedDataNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public string AttachedDataNetworkId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim#slice_id MobileNetworkSim#slice_id}.</summary>
        [JsiiProperty(name: "sliceId", typeJson: "{\"primitive\":\"string\"}")]
        public string SliceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim#static_ipv4_address MobileNetworkSim#static_ipv4_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "staticIpv4Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StaticIpv4Address
        {
            get;
            set;
        }
    }
}
