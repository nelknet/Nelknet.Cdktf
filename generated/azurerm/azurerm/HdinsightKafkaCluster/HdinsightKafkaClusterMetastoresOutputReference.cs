using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterMetastoresOutputReference), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HdinsightKafkaClusterMetastoresOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HdinsightKafkaClusterMetastoresOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HdinsightKafkaClusterMetastoresOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightKafkaClusterMetastoresOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAmbari", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresAmbari\"}}]")]
        public virtual void PutAmbari(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresAmbari @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresAmbari)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHive", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresHive\"}}]")]
        public virtual void PutHive(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresHive @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresHive)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOozie", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresOozie\"}}]")]
        public virtual void PutOozie(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresOozie @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresOozie)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmbari")]
        public virtual void ResetAmbari()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHive")]
        public virtual void ResetHive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOozie")]
        public virtual void ResetOozie()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresAmbariOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterMetastoresAmbariOutputReference Ambari
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterMetastoresAmbariOutputReference>()!;
        }

        [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresHiveOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterMetastoresHiveOutputReference Hive
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterMetastoresHiveOutputReference>()!;
        }

        [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresOozieOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterMetastoresOozieOutputReference Oozie
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterMetastoresOozieOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ambariInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresAmbari\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresAmbari? AmbariInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresAmbari?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hiveInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresHive\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresHive? HiveInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresHive?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oozieInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresOozie\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresOozie? OozieInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresOozie?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastores\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastores? InternalValue
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastores?>();
            set => SetInstanceProperty(value);
        }
    }
}
