using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    [JsiiInterface(nativeType: typeof(IMonitorDataCollectionRuleDataSourcesLogFileSettings), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettings")]
    public interface IMonitorDataCollectionRuleDataSourcesLogFileSettings
    {
        /// <summary>text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#text MonitorDataCollectionRule#text}
        /// </remarks>
        [JsiiProperty(name: "text", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettingsText\"}")]
        azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFileSettingsText Text
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorDataCollectionRuleDataSourcesLogFileSettings), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFileSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>text block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#text MonitorDataCollectionRule#text}
            /// </remarks>
            [JsiiProperty(name: "text", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettingsText\"}")]
            public azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFileSettingsText Text
            {
                get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFileSettingsText>()!;
            }
        }
    }
}
