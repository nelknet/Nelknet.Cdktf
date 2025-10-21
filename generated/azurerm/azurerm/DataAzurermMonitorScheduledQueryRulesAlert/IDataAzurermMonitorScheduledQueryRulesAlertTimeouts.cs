using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMonitorScheduledQueryRulesAlert
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMonitorScheduledQueryRulesAlertTimeouts), fullyQualifiedName: "azurerm.dataAzurermMonitorScheduledQueryRulesAlert.DataAzurermMonitorScheduledQueryRulesAlertTimeouts")]
    public interface IDataAzurermMonitorScheduledQueryRulesAlertTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_scheduled_query_rules_alert#read DataAzurermMonitorScheduledQueryRulesAlert#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMonitorScheduledQueryRulesAlertTimeouts), fullyQualifiedName: "azurerm.dataAzurermMonitorScheduledQueryRulesAlert.DataAzurermMonitorScheduledQueryRulesAlertTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMonitorScheduledQueryRulesAlert.IDataAzurermMonitorScheduledQueryRulesAlertTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_scheduled_query_rules_alert#read DataAzurermMonitorScheduledQueryRulesAlert#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
