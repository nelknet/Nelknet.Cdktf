using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMonitorDataCollectionRule
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsOutputReference), fullyQualifiedName: "azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermMonitorDataCollectionRuleDestinationsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermMonitorDataCollectionRuleDestinationsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermMonitorDataCollectionRuleDestinationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermMonitorDataCollectionRuleDestinationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "azureMonitorMetrics", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsAzureMonitorMetricsList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsAzureMonitorMetricsList AzureMonitorMetrics
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsAzureMonitorMetricsList>()!;
        }

        [JsiiProperty(name: "eventHub", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsEventHubList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsEventHubList EventHub
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsEventHubList>()!;
        }

        [JsiiProperty(name: "eventHubDirect", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsEventHubDirectList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsEventHubDirectList EventHubDirect
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsEventHubDirectList>()!;
        }

        [JsiiProperty(name: "logAnalytics", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsLogAnalyticsList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsLogAnalyticsList LogAnalytics
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsLogAnalyticsList>()!;
        }

        [JsiiProperty(name: "monitorAccount", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsMonitorAccountList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsMonitorAccountList MonitorAccount
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsMonitorAccountList>()!;
        }

        [JsiiProperty(name: "storageBlob", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsStorageBlobList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsStorageBlobList StorageBlob
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsStorageBlobList>()!;
        }

        [JsiiProperty(name: "storageBlobDirect", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsStorageBlobDirectList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsStorageBlobDirectList StorageBlobDirect
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsStorageBlobDirectList>()!;
        }

        [JsiiProperty(name: "storageTableDirect", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsStorageTableDirectList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsStorageTableDirectList StorageTableDirect
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsStorageTableDirectList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinations\"}", isOptional: true)]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.IDataAzurermMonitorDataCollectionRuleDestinations? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.IDataAzurermMonitorDataCollectionRuleDestinations?>();
            set => SetInstanceProperty(value);
        }
    }
}
