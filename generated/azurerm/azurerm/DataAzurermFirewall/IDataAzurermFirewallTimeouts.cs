using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermFirewall
{
    [JsiiInterface(nativeType: typeof(IDataAzurermFirewallTimeouts), fullyQualifiedName: "azurerm.dataAzurermFirewall.DataAzurermFirewallTimeouts")]
    public interface IDataAzurermFirewallTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall#read DataAzurermFirewall#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermFirewallTimeouts), fullyQualifiedName: "azurerm.dataAzurermFirewall.DataAzurermFirewallTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermFirewall.IDataAzurermFirewallTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall#read DataAzurermFirewall#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
