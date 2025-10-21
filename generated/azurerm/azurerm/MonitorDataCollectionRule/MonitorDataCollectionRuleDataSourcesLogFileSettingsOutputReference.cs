using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    [JsiiClass(nativeType: typeof(azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettingsOutputReference), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MonitorDataCollectionRuleDataSourcesLogFileSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MonitorDataCollectionRuleDataSourcesLogFileSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorDataCollectionRuleDataSourcesLogFileSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorDataCollectionRuleDataSourcesLogFileSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putText", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettingsText\"}}]")]
        public virtual void PutText(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFileSettingsText @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFileSettingsText)}, new object[]{@value});
        }

        [JsiiProperty(name: "text", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettingsTextOutputReference\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettingsTextOutputReference Text
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettingsTextOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "textInput", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettingsText\"}", isOptional: true)]
        public virtual azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFileSettingsText? TextInput
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFileSettingsText?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettings\"}", isOptional: true)]
        public virtual azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFileSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFileSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
