using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LbOutboundRule
{
    [JsiiInterface(nativeType: typeof(ILbOutboundRuleFrontendIpConfiguration), fullyQualifiedName: "azurerm.lbOutboundRule.LbOutboundRuleFrontendIpConfiguration")]
    public interface ILbOutboundRuleFrontendIpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule#name LbOutboundRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbOutboundRuleFrontendIpConfiguration), fullyQualifiedName: "azurerm.lbOutboundRule.LbOutboundRuleFrontendIpConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.LbOutboundRule.ILbOutboundRuleFrontendIpConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule#name LbOutboundRule#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
