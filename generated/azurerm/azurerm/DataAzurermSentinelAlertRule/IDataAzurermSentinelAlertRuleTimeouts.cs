using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSentinelAlertRule
{
    [JsiiInterface(nativeType: typeof(IDataAzurermSentinelAlertRuleTimeouts), fullyQualifiedName: "azurerm.dataAzurermSentinelAlertRule.DataAzurermSentinelAlertRuleTimeouts")]
    public interface IDataAzurermSentinelAlertRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule#read DataAzurermSentinelAlertRule#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermSentinelAlertRuleTimeouts), fullyQualifiedName: "azurerm.dataAzurermSentinelAlertRule.DataAzurermSentinelAlertRuleTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermSentinelAlertRule.IDataAzurermSentinelAlertRuleTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule#read DataAzurermSentinelAlertRule#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
