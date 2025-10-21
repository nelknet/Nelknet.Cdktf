using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermRedisCache
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermRedisCache.DataAzurermRedisCacheRedisConfigurationOutputReference), fullyQualifiedName: "azurerm.dataAzurermRedisCache.DataAzurermRedisCacheRedisConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermRedisCacheRedisConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermRedisCacheRedisConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermRedisCacheRedisConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermRedisCacheRedisConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "activeDirectoryAuthenticationEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ActiveDirectoryAuthenticationEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "aofBackupEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AofBackupEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "aofStorageConnectionString0", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AofStorageConnectionString0
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "aofStorageConnectionString1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AofStorageConnectionString1
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authenticationEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AuthenticationEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "dataPersistenceAuthenticationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataPersistenceAuthenticationMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxclients", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Maxclients
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxfragmentationmemoryReserved", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxfragmentationmemoryReserved
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxmemoryDelta", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxmemoryDelta
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxmemoryPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxmemoryPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxmemoryReserved", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxmemoryReserved
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "notifyKeyspaceEvents", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotifyKeyspaceEvents
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rdbBackupEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable RdbBackupEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "rdbBackupFrequency", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RdbBackupFrequency
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rdbBackupMaxSnapshotCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RdbBackupMaxSnapshotCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rdbStorageConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RdbStorageConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageAccountSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountSubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermRedisCache.DataAzurermRedisCacheRedisConfiguration\"}", isOptional: true)]
        public virtual azurerm.DataAzurermRedisCache.IDataAzurermRedisCacheRedisConfiguration? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermRedisCache.IDataAzurermRedisCacheRedisConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
