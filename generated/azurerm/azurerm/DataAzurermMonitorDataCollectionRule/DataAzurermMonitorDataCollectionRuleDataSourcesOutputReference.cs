using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMonitorDataCollectionRule
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesOutputReference), fullyQualifiedName: "azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermMonitorDataCollectionRuleDataSourcesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermMonitorDataCollectionRuleDataSourcesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermMonitorDataCollectionRuleDataSourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermMonitorDataCollectionRuleDataSourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dataImport", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesDataImportList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesDataImportList DataImport
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesDataImportList>()!;
        }

        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesExtensionList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesExtensionList Extension
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesExtensionList>()!;
        }

        [JsiiProperty(name: "iisLog", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesIisLogList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesIisLogList IisLog
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesIisLogList>()!;
        }

        [JsiiProperty(name: "logFile", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesLogFileList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesLogFileList LogFile
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesLogFileList>()!;
        }

        [JsiiProperty(name: "performanceCounter", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesPerformanceCounterList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesPerformanceCounterList PerformanceCounter
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesPerformanceCounterList>()!;
        }

        [JsiiProperty(name: "platformTelemetry", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesPlatformTelemetryList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesPlatformTelemetryList PlatformTelemetry
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesPlatformTelemetryList>()!;
        }

        [JsiiProperty(name: "prometheusForwarder", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesPrometheusForwarderList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesPrometheusForwarderList PrometheusForwarder
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesPrometheusForwarderList>()!;
        }

        [JsiiProperty(name: "syslog", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesSyslogList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesSyslogList Syslog
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesSyslogList>()!;
        }

        [JsiiProperty(name: "windowsEventLog", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesWindowsEventLogList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesWindowsEventLogList WindowsEventLog
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesWindowsEventLogList>()!;
        }

        [JsiiProperty(name: "windowsFirewallLog", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesWindowsFirewallLogList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesWindowsFirewallLogList WindowsFirewallLog
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesWindowsFirewallLogList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSources\"}", isOptional: true)]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.IDataAzurermMonitorDataCollectionRuleDataSources? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.IDataAzurermMonitorDataCollectionRuleDataSources?>();
            set => SetInstanceProperty(value);
        }
    }
}
