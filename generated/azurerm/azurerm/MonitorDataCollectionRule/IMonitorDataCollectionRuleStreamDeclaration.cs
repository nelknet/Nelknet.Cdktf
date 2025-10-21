using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    [JsiiInterface(nativeType: typeof(IMonitorDataCollectionRuleStreamDeclaration), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleStreamDeclaration")]
    public interface IMonitorDataCollectionRuleStreamDeclaration
    {
        /// <summary>column block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#column MonitorDataCollectionRule#column}
        /// </remarks>
        [JsiiProperty(name: "column", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleStreamDeclarationColumn\"},\"kind\":\"array\"}}]}}")]
        object Column
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#stream_name MonitorDataCollectionRule#stream_name}.</summary>
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}")]
        string StreamName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorDataCollectionRuleStreamDeclaration), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleStreamDeclaration")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleStreamDeclaration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>column block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#column MonitorDataCollectionRule#column}
            /// </remarks>
            [JsiiProperty(name: "column", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleStreamDeclarationColumn\"},\"kind\":\"array\"}}]}}")]
            public object Column
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#stream_name MonitorDataCollectionRule#stream_name}.</summary>
            [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
