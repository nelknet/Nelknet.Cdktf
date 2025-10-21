using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    [JsiiInterface(nativeType: typeof(IMonitorDataCollectionRuleDataSourcesIisLog), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesIisLog")]
    public interface IMonitorDataCollectionRuleDataSourcesIisLog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#name MonitorDataCollectionRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#streams MonitorDataCollectionRule#streams}.</summary>
        [JsiiProperty(name: "streams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Streams
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#log_directories MonitorDataCollectionRule#log_directories}.</summary>
        [JsiiProperty(name: "logDirectories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LogDirectories
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorDataCollectionRuleDataSourcesIisLog), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesIisLog")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesIisLog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#name MonitorDataCollectionRule#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#streams MonitorDataCollectionRule#streams}.</summary>
            [JsiiProperty(name: "streams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Streams
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#log_directories MonitorDataCollectionRule#log_directories}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logDirectories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LogDirectories
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
