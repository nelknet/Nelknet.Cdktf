using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FirewallPolicy
{
    [JsiiInterface(nativeType: typeof(IFirewallPolicyDns), fullyQualifiedName: "azurerm.firewallPolicy.FirewallPolicyDns")]
    public interface IFirewallPolicyDns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#proxy_enabled FirewallPolicy#proxy_enabled}.</summary>
        [JsiiProperty(name: "proxyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProxyEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#servers FirewallPolicy#servers}.</summary>
        [JsiiProperty(name: "servers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Servers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFirewallPolicyDns), fullyQualifiedName: "azurerm.firewallPolicy.FirewallPolicyDns")]
        internal sealed class _Proxy : DeputyBase, azurerm.FirewallPolicy.IFirewallPolicyDns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#proxy_enabled FirewallPolicy#proxy_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "proxyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ProxyEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#servers FirewallPolicy#servers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "servers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Servers
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
