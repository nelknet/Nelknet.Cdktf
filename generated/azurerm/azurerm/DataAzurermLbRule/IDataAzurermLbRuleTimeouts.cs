using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLbRule
{
    [JsiiInterface(nativeType: typeof(IDataAzurermLbRuleTimeouts), fullyQualifiedName: "azurerm.dataAzurermLbRule.DataAzurermLbRuleTimeouts")]
    public interface IDataAzurermLbRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_rule#read DataAzurermLbRule#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermLbRuleTimeouts), fullyQualifiedName: "azurerm.dataAzurermLbRule.DataAzurermLbRuleTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermLbRule.IDataAzurermLbRuleTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_rule#read DataAzurermLbRule#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
