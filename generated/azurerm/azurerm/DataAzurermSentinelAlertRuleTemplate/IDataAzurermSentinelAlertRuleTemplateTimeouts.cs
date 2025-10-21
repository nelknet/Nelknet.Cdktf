using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSentinelAlertRuleTemplate
{
    [JsiiInterface(nativeType: typeof(IDataAzurermSentinelAlertRuleTemplateTimeouts), fullyQualifiedName: "azurerm.dataAzurermSentinelAlertRuleTemplate.DataAzurermSentinelAlertRuleTemplateTimeouts")]
    public interface IDataAzurermSentinelAlertRuleTemplateTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule_template#read DataAzurermSentinelAlertRuleTemplate#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermSentinelAlertRuleTemplateTimeouts), fullyQualifiedName: "azurerm.dataAzurermSentinelAlertRuleTemplate.DataAzurermSentinelAlertRuleTemplateTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermSentinelAlertRuleTemplate.IDataAzurermSentinelAlertRuleTemplateTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule_template#read DataAzurermSentinelAlertRuleTemplate#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
