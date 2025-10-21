using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AiServices
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.aiServices.AiServicesNetworkAcls")]
    public class AiServicesNetworkAcls : azurerm.AiServices.IAiServicesNetworkAcls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#default_action AiServices#default_action}.</summary>
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#ip_rules AiServices#ip_rules}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipRules", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IpRules
        {
            get;
            set;
        }

        private object? _virtualNetworkRules;

        /// <summary>virtual_network_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#virtual_network_rules AiServices#virtual_network_rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.aiServices.AiServicesNetworkAclsVirtualNetworkRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VirtualNetworkRules
        {
            get => _virtualNetworkRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.AiServices.IAiServicesNetworkAclsVirtualNetworkRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.AiServices.IAiServicesNetworkAclsVirtualNetworkRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _virtualNetworkRules = value;
            }
        }
    }
}
