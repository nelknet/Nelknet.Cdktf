using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkService
{
    [JsiiInterface(nativeType: typeof(IMobileNetworkServicePccRule), fullyQualifiedName: "azurerm.mobileNetworkService.MobileNetworkServicePccRule")]
    public interface IMobileNetworkServicePccRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#name MobileNetworkService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#precedence MobileNetworkService#precedence}.</summary>
        [JsiiProperty(name: "precedence", typeJson: "{\"primitive\":\"number\"}")]
        double Precedence
        {
            get;
        }

        /// <summary>service_data_flow_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#service_data_flow_template MobileNetworkService#service_data_flow_template}
        /// </remarks>
        [JsiiProperty(name: "serviceDataFlowTemplate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleServiceDataFlowTemplate\"},\"kind\":\"array\"}}]}}")]
        object ServiceDataFlowTemplate
        {
            get;
        }

        /// <summary>qos_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#qos_policy MobileNetworkService#qos_policy}
        /// </remarks>
        [JsiiProperty(name: "qosPolicy", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicy? QosPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#traffic_control_enabled MobileNetworkService#traffic_control_enabled}.</summary>
        [JsiiProperty(name: "trafficControlEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrafficControlEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMobileNetworkServicePccRule), fullyQualifiedName: "azurerm.mobileNetworkService.MobileNetworkServicePccRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.MobileNetworkService.IMobileNetworkServicePccRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#name MobileNetworkService#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#precedence MobileNetworkService#precedence}.</summary>
            [JsiiProperty(name: "precedence", typeJson: "{\"primitive\":\"number\"}")]
            public double Precedence
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>service_data_flow_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#service_data_flow_template MobileNetworkService#service_data_flow_template}
            /// </remarks>
            [JsiiProperty(name: "serviceDataFlowTemplate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleServiceDataFlowTemplate\"},\"kind\":\"array\"}}]}}")]
            public object ServiceDataFlowTemplate
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>qos_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#qos_policy MobileNetworkService#qos_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "qosPolicy", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicy\"}", isOptional: true)]
            public azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicy? QosPolicy
            {
                get => GetInstanceProperty<azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#traffic_control_enabled MobileNetworkService#traffic_control_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trafficControlEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? TrafficControlEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
