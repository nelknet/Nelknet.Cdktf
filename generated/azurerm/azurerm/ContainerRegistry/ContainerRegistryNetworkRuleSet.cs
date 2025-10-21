using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistry
{
    [JsiiByValue(fqn: "azurerm.containerRegistry.ContainerRegistryNetworkRuleSet")]
    public class ContainerRegistryNetworkRuleSet : azurerm.ContainerRegistry.IContainerRegistryNetworkRuleSet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#default_action ContainerRegistry#default_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultAction
        {
            get;
            set;
        }

        private object? _ipRule;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#ip_rule ContainerRegistry#ip_rule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerRegistry.ContainerRegistryNetworkRuleSetIpRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IpRule
        {
            get => _ipRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerRegistry.IContainerRegistryNetworkRuleSetIpRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerRegistry.IContainerRegistryNetworkRuleSetIpRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipRule = value;
            }
        }
    }
}
