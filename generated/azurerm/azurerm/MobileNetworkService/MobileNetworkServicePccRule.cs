using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mobileNetworkService.MobileNetworkServicePccRule")]
    public class MobileNetworkServicePccRule : azurerm.MobileNetworkService.IMobileNetworkServicePccRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#name MobileNetworkService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#precedence MobileNetworkService#precedence}.</summary>
        [JsiiProperty(name: "precedence", typeJson: "{\"primitive\":\"number\"}")]
        public double Precedence
        {
            get;
            set;
        }

        private object _serviceDataFlowTemplate;

        /// <summary>service_data_flow_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#service_data_flow_template MobileNetworkService#service_data_flow_template}
        /// </remarks>
        [JsiiProperty(name: "serviceDataFlowTemplate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleServiceDataFlowTemplate\"},\"kind\":\"array\"}}]}}")]
        public object ServiceDataFlowTemplate
        {
            get => _serviceDataFlowTemplate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MobileNetworkService.IMobileNetworkServicePccRuleServiceDataFlowTemplate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MobileNetworkService.IMobileNetworkServicePccRuleServiceDataFlowTemplate).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MobileNetworkService.IMobileNetworkServicePccRuleServiceDataFlowTemplate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _serviceDataFlowTemplate = value;
            }
        }

        /// <summary>qos_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#qos_policy MobileNetworkService#qos_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qosPolicy", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicy\"}", isOptional: true)]
        public azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicy? QosPolicy
        {
            get;
            set;
        }

        private object? _trafficControlEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#traffic_control_enabled MobileNetworkService#traffic_control_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trafficControlEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? TrafficControlEnabled
        {
            get => _trafficControlEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trafficControlEnabled = value;
            }
        }
    }
}
