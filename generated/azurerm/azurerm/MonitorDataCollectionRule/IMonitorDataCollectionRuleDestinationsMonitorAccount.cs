using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    [JsiiInterface(nativeType: typeof(IMonitorDataCollectionRuleDestinationsMonitorAccount), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsMonitorAccount")]
    public interface IMonitorDataCollectionRuleDestinationsMonitorAccount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#monitor_account_id MonitorDataCollectionRule#monitor_account_id}.</summary>
        [JsiiProperty(name: "monitorAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string MonitorAccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#name MonitorDataCollectionRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorDataCollectionRuleDestinationsMonitorAccount), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsMonitorAccount")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsMonitorAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#monitor_account_id MonitorDataCollectionRule#monitor_account_id}.</summary>
            [JsiiProperty(name: "monitorAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string MonitorAccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#name MonitorDataCollectionRule#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
