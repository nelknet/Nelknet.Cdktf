using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLbOutboundRule
{
    [JsiiInterface(nativeType: typeof(IDataAzurermLbOutboundRuleTimeouts), fullyQualifiedName: "azurerm.dataAzurermLbOutboundRule.DataAzurermLbOutboundRuleTimeouts")]
    public interface IDataAzurermLbOutboundRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_outbound_rule#read DataAzurermLbOutboundRule#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermLbOutboundRuleTimeouts), fullyQualifiedName: "azurerm.dataAzurermLbOutboundRule.DataAzurermLbOutboundRuleTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermLbOutboundRule.IDataAzurermLbOutboundRuleTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_outbound_rule#read DataAzurermLbOutboundRule#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
