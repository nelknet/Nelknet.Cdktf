using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(IDataAzurermFirewallPolicyTimeouts), fullyQualifiedName: "azurerm.dataAzurermFirewallPolicy.DataAzurermFirewallPolicyTimeouts")]
    public interface IDataAzurermFirewallPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall_policy#read DataAzurermFirewallPolicy#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermFirewallPolicyTimeouts), fullyQualifiedName: "azurerm.dataAzurermFirewallPolicy.DataAzurermFirewallPolicyTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermFirewallPolicy.IDataAzurermFirewallPolicyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall_policy#read DataAzurermFirewallPolicy#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
