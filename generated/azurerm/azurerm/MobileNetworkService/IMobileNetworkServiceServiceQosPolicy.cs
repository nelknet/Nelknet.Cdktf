using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkService
{
    [JsiiInterface(nativeType: typeof(IMobileNetworkServiceServiceQosPolicy), fullyQualifiedName: "azurerm.mobileNetworkService.MobileNetworkServiceServiceQosPolicy")]
    public interface IMobileNetworkServiceServiceQosPolicy
    {
        /// <summary>maximum_bit_rate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#maximum_bit_rate MobileNetworkService#maximum_bit_rate}
        /// </remarks>
        [JsiiProperty(name: "maximumBitRate", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServiceServiceQosPolicyMaximumBitRate\"}")]
        azurerm.MobileNetworkService.IMobileNetworkServiceServiceQosPolicyMaximumBitRate MaximumBitRate
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#qos_indicator MobileNetworkService#qos_indicator}.</summary>
        [JsiiProperty(name: "qosIndicator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? QosIndicator
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMobileNetworkServiceServiceQosPolicy), fullyQualifiedName: "azurerm.mobileNetworkService.MobileNetworkServiceServiceQosPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.MobileNetworkService.IMobileNetworkServiceServiceQosPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>maximum_bit_rate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#maximum_bit_rate MobileNetworkService#maximum_bit_rate}
            /// </remarks>
            [JsiiProperty(name: "maximumBitRate", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServiceServiceQosPolicyMaximumBitRate\"}")]
            public azurerm.MobileNetworkService.IMobileNetworkServiceServiceQosPolicyMaximumBitRate MaximumBitRate
            {
                get => GetInstanceProperty<azurerm.MobileNetworkService.IMobileNetworkServiceServiceQosPolicyMaximumBitRate>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#allocation_and_retention_priority_level MobileNetworkService#allocation_and_retention_priority_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allocationAndRetentionPriorityLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AllocationAndRetentionPriorityLevel
            {
                get => GetInstanceProperty<double?>();
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#qos_indicator MobileNetworkService#qos_indicator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "qosIndicator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? QosIndicator
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
