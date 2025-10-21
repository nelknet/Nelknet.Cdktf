using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPaloAltoLocalRulestack
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPaloAltoLocalRulestackTimeouts), fullyQualifiedName: "azurerm.dataAzurermPaloAltoLocalRulestack.DataAzurermPaloAltoLocalRulestackTimeouts")]
    public interface IDataAzurermPaloAltoLocalRulestackTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/palo_alto_local_rulestack#read DataAzurermPaloAltoLocalRulestack#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPaloAltoLocalRulestackTimeouts), fullyQualifiedName: "azurerm.dataAzurermPaloAltoLocalRulestack.DataAzurermPaloAltoLocalRulestackTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPaloAltoLocalRulestack.IDataAzurermPaloAltoLocalRulestackTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/palo_alto_local_rulestack#read DataAzurermPaloAltoLocalRulestack#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
