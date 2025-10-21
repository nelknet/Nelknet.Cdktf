using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsResolverForwardingRule
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPrivateDnsResolverForwardingRuleTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsResolverForwardingRule.DataAzurermPrivateDnsResolverForwardingRuleTimeouts")]
    public interface IDataAzurermPrivateDnsResolverForwardingRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_forwarding_rule#read DataAzurermPrivateDnsResolverForwardingRule#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPrivateDnsResolverForwardingRuleTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsResolverForwardingRule.DataAzurermPrivateDnsResolverForwardingRuleTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPrivateDnsResolverForwardingRule.IDataAzurermPrivateDnsResolverForwardingRuleTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_forwarding_rule#read DataAzurermPrivateDnsResolverForwardingRule#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
