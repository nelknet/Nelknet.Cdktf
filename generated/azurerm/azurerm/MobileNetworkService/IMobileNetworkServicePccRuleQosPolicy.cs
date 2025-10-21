using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkService
{
    [JsiiInterface(nativeType: typeof(IMobileNetworkServicePccRuleQosPolicy), fullyQualifiedName: "azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicy")]
    public interface IMobileNetworkServicePccRuleQosPolicy
    {
        /// <summary>maximum_bit_rate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#maximum_bit_rate MobileNetworkService#maximum_bit_rate}
        /// </remarks>
        [JsiiProperty(name: "maximumBitRate", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicyMaximumBitRate\"}")]
        azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyMaximumBitRate MaximumBitRate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#qos_indicator MobileNetworkService#qos_indicator}.</summary>
        [JsiiProperty(name: "qosIndicator", typeJson: "{\"primitive\":\"number\"}")]
        double QosIndicator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#allocation_and_retention_priority_level MobileNetworkService#allocation_and_retention_priority_level}.</summary>
        [JsiiProperty(name: "allocationAndRetentionPriorityLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AllocationAndRetentionPriorityLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>guaranteed_bit_rate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#guaranteed_bit_rate MobileNetworkService#guaranteed_bit_rate}
        /// </remarks>
        [JsiiProperty(name: "guaranteedBitRate", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicyGuaranteedBitRate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyGuaranteedBitRate? GuaranteedBitRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#preemption_capability MobileNetworkService#preemption_capability}.</summary>
        [JsiiProperty(name: "preemptionCapability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreemptionCapability
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#preemption_vulnerability MobileNetworkService#preemption_vulnerability}.</summary>
        [JsiiProperty(name: "preemptionVulnerability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreemptionVulnerability
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMobileNetworkServicePccRuleQosPolicy), fullyQualifiedName: "azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>maximum_bit_rate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#maximum_bit_rate MobileNetworkService#maximum_bit_rate}
            /// </remarks>
            [JsiiProperty(name: "maximumBitRate", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicyMaximumBitRate\"}")]
            public azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyMaximumBitRate MaximumBitRate
            {
                get => GetInstanceProperty<azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyMaximumBitRate>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#qos_indicator MobileNetworkService#qos_indicator}.</summary>
            [JsiiProperty(name: "qosIndicator", typeJson: "{\"primitive\":\"number\"}")]
            public double QosIndicator
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#allocation_and_retention_priority_level MobileNetworkService#allocation_and_retention_priority_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allocationAndRetentionPriorityLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AllocationAndRetentionPriorityLevel
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>guaranteed_bit_rate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#guaranteed_bit_rate MobileNetworkService#guaranteed_bit_rate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "guaranteedBitRate", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicyGuaranteedBitRate\"}", isOptional: true)]
            public azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyGuaranteedBitRate? GuaranteedBitRate
            {
                get => GetInstanceProperty<azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyGuaranteedBitRate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#preemption_capability MobileNetworkService#preemption_capability}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preemptionCapability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreemptionCapability
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#preemption_vulnerability MobileNetworkService#preemption_vulnerability}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preemptionVulnerability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreemptionVulnerability
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
