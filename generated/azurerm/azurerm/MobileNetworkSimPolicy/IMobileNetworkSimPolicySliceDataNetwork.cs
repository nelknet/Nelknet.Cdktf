using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkSimPolicy
{
    [JsiiInterface(nativeType: typeof(IMobileNetworkSimPolicySliceDataNetwork), fullyQualifiedName: "azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicySliceDataNetwork")]
    public interface IMobileNetworkSimPolicySliceDataNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#allowed_services_ids MobileNetworkSimPolicy#allowed_services_ids}.</summary>
        [JsiiProperty(name: "allowedServicesIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedServicesIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#data_network_id MobileNetworkSimPolicy#data_network_id}.</summary>
        [JsiiProperty(name: "dataNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        string DataNetworkId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#qos_indicator MobileNetworkSimPolicy#qos_indicator}.</summary>
        [JsiiProperty(name: "qosIndicator", typeJson: "{\"primitive\":\"number\"}")]
        double QosIndicator
        {
            get;
        }

        /// <summary>session_aggregate_maximum_bit_rate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#session_aggregate_maximum_bit_rate MobileNetworkSimPolicy#session_aggregate_maximum_bit_rate}
        /// </remarks>
        [JsiiProperty(name: "sessionAggregateMaximumBitRate", typeJson: "{\"fqn\":\"azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicySliceDataNetworkSessionAggregateMaximumBitRate\"}")]
        azurerm.MobileNetworkSimPolicy.IMobileNetworkSimPolicySliceDataNetworkSessionAggregateMaximumBitRate SessionAggregateMaximumBitRate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#additional_allowed_session_types MobileNetworkSimPolicy#additional_allowed_session_types}.</summary>
        [JsiiProperty(name: "additionalAllowedSessionTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AdditionalAllowedSessionTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#allocation_and_retention_priority_level MobileNetworkSimPolicy#allocation_and_retention_priority_level}.</summary>
        [JsiiProperty(name: "allocationAndRetentionPriorityLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AllocationAndRetentionPriorityLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#default_session_type MobileNetworkSimPolicy#default_session_type}.</summary>
        [JsiiProperty(name: "defaultSessionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultSessionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#max_buffered_packets MobileNetworkSimPolicy#max_buffered_packets}.</summary>
        [JsiiProperty(name: "maxBufferedPackets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxBufferedPackets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#preemption_capability MobileNetworkSimPolicy#preemption_capability}.</summary>
        [JsiiProperty(name: "preemptionCapability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreemptionCapability
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#preemption_vulnerability MobileNetworkSimPolicy#preemption_vulnerability}.</summary>
        [JsiiProperty(name: "preemptionVulnerability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreemptionVulnerability
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMobileNetworkSimPolicySliceDataNetwork), fullyQualifiedName: "azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicySliceDataNetwork")]
        internal sealed class _Proxy : DeputyBase, azurerm.MobileNetworkSimPolicy.IMobileNetworkSimPolicySliceDataNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#allowed_services_ids MobileNetworkSimPolicy#allowed_services_ids}.</summary>
            [JsiiProperty(name: "allowedServicesIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedServicesIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#data_network_id MobileNetworkSimPolicy#data_network_id}.</summary>
            [JsiiProperty(name: "dataNetworkId", typeJson: "{\"primitive\":\"string\"}")]
            public string DataNetworkId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#qos_indicator MobileNetworkSimPolicy#qos_indicator}.</summary>
            [JsiiProperty(name: "qosIndicator", typeJson: "{\"primitive\":\"number\"}")]
            public double QosIndicator
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>session_aggregate_maximum_bit_rate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#session_aggregate_maximum_bit_rate MobileNetworkSimPolicy#session_aggregate_maximum_bit_rate}
            /// </remarks>
            [JsiiProperty(name: "sessionAggregateMaximumBitRate", typeJson: "{\"fqn\":\"azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicySliceDataNetworkSessionAggregateMaximumBitRate\"}")]
            public azurerm.MobileNetworkSimPolicy.IMobileNetworkSimPolicySliceDataNetworkSessionAggregateMaximumBitRate SessionAggregateMaximumBitRate
            {
                get => GetInstanceProperty<azurerm.MobileNetworkSimPolicy.IMobileNetworkSimPolicySliceDataNetworkSessionAggregateMaximumBitRate>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#additional_allowed_session_types MobileNetworkSimPolicy#additional_allowed_session_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalAllowedSessionTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AdditionalAllowedSessionTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#allocation_and_retention_priority_level MobileNetworkSimPolicy#allocation_and_retention_priority_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allocationAndRetentionPriorityLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AllocationAndRetentionPriorityLevel
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#default_session_type MobileNetworkSimPolicy#default_session_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultSessionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultSessionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#max_buffered_packets MobileNetworkSimPolicy#max_buffered_packets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxBufferedPackets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxBufferedPackets
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#preemption_capability MobileNetworkSimPolicy#preemption_capability}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preemptionCapability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreemptionCapability
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#preemption_vulnerability MobileNetworkSimPolicy#preemption_vulnerability}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preemptionVulnerability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreemptionVulnerability
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
