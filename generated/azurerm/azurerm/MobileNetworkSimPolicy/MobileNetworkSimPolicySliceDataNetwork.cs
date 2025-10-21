using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkSimPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicySliceDataNetwork")]
    public class MobileNetworkSimPolicySliceDataNetwork : azurerm.MobileNetworkSimPolicy.IMobileNetworkSimPolicySliceDataNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#allowed_services_ids MobileNetworkSimPolicy#allowed_services_ids}.</summary>
        [JsiiProperty(name: "allowedServicesIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AllowedServicesIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#data_network_id MobileNetworkSimPolicy#data_network_id}.</summary>
        [JsiiProperty(name: "dataNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public string DataNetworkId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#qos_indicator MobileNetworkSimPolicy#qos_indicator}.</summary>
        [JsiiProperty(name: "qosIndicator", typeJson: "{\"primitive\":\"number\"}")]
        public double QosIndicator
        {
            get;
            set;
        }

        /// <summary>session_aggregate_maximum_bit_rate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#session_aggregate_maximum_bit_rate MobileNetworkSimPolicy#session_aggregate_maximum_bit_rate}
        /// </remarks>
        [JsiiProperty(name: "sessionAggregateMaximumBitRate", typeJson: "{\"fqn\":\"azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicySliceDataNetworkSessionAggregateMaximumBitRate\"}")]
        public azurerm.MobileNetworkSimPolicy.IMobileNetworkSimPolicySliceDataNetworkSessionAggregateMaximumBitRate SessionAggregateMaximumBitRate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#additional_allowed_session_types MobileNetworkSimPolicy#additional_allowed_session_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalAllowedSessionTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AdditionalAllowedSessionTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#allocation_and_retention_priority_level MobileNetworkSimPolicy#allocation_and_retention_priority_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allocationAndRetentionPriorityLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AllocationAndRetentionPriorityLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#default_session_type MobileNetworkSimPolicy#default_session_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultSessionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultSessionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#max_buffered_packets MobileNetworkSimPolicy#max_buffered_packets}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBufferedPackets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxBufferedPackets
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#preemption_capability MobileNetworkSimPolicy#preemption_capability}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preemptionCapability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreemptionCapability
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#preemption_vulnerability MobileNetworkSimPolicy#preemption_vulnerability}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preemptionVulnerability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreemptionVulnerability
        {
            get;
            set;
        }
    }
}
