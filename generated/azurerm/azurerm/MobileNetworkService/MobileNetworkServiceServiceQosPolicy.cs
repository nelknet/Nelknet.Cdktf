using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mobileNetworkService.MobileNetworkServiceServiceQosPolicy")]
    public class MobileNetworkServiceServiceQosPolicy : azurerm.MobileNetworkService.IMobileNetworkServiceServiceQosPolicy
    {
        /// <summary>maximum_bit_rate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#maximum_bit_rate MobileNetworkService#maximum_bit_rate}
        /// </remarks>
        [JsiiProperty(name: "maximumBitRate", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServiceServiceQosPolicyMaximumBitRate\"}")]
        public azurerm.MobileNetworkService.IMobileNetworkServiceServiceQosPolicyMaximumBitRate MaximumBitRate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#allocation_and_retention_priority_level MobileNetworkService#allocation_and_retention_priority_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allocationAndRetentionPriorityLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AllocationAndRetentionPriorityLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#preemption_capability MobileNetworkService#preemption_capability}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preemptionCapability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreemptionCapability
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#preemption_vulnerability MobileNetworkService#preemption_vulnerability}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preemptionVulnerability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreemptionVulnerability
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#qos_indicator MobileNetworkService#qos_indicator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "qosIndicator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? QosIndicator
        {
            get;
            set;
        }
    }
}
