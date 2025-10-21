using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolNetworkConfigurationEndpointConfiguration")]
    public class BatchPoolNetworkConfigurationEndpointConfiguration : azurerm.BatchPool.IBatchPoolNetworkConfigurationEndpointConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#backend_port BatchPool#backend_port}.</summary>
        [JsiiProperty(name: "backendPort", typeJson: "{\"primitive\":\"number\"}")]
        public double BackendPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#frontend_port_range BatchPool#frontend_port_range}.</summary>
        [JsiiProperty(name: "frontendPortRange", typeJson: "{\"primitive\":\"string\"}")]
        public string FrontendPortRange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#name BatchPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#protocol BatchPool#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        private object? _networkSecurityGroupRules;

        /// <summary>network_security_group_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#network_security_group_rules BatchPool#network_security_group_rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkSecurityGroupRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkSecurityGroupRules
        {
            get => _networkSecurityGroupRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkSecurityGroupRules = value;
            }
        }
    }
}
