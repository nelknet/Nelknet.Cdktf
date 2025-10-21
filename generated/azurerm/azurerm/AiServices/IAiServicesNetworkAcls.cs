using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AiServices
{
    [JsiiInterface(nativeType: typeof(IAiServicesNetworkAcls), fullyQualifiedName: "azurerm.aiServices.AiServicesNetworkAcls")]
    public interface IAiServicesNetworkAcls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#default_action AiServices#default_action}.</summary>
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultAction
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#ip_rules AiServices#ip_rules}.</summary>
        [JsiiProperty(name: "ipRules", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IpRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>virtual_network_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#virtual_network_rules AiServices#virtual_network_rules}
        /// </remarks>
        [JsiiProperty(name: "virtualNetworkRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.aiServices.AiServicesNetworkAclsVirtualNetworkRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VirtualNetworkRules
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiServicesNetworkAcls), fullyQualifiedName: "azurerm.aiServices.AiServicesNetworkAcls")]
        internal sealed class _Proxy : DeputyBase, azurerm.AiServices.IAiServicesNetworkAcls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#default_action AiServices#default_action}.</summary>
            [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultAction
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#ip_rules AiServices#ip_rules}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipRules", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IpRules
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>virtual_network_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#virtual_network_rules AiServices#virtual_network_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNetworkRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.aiServices.AiServicesNetworkAclsVirtualNetworkRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VirtualNetworkRules
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
