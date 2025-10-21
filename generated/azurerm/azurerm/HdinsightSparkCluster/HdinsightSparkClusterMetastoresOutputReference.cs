using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HdinsightSparkCluster.HdinsightSparkClusterMetastoresOutputReference), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HdinsightSparkClusterMetastoresOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HdinsightSparkClusterMetastoresOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HdinsightSparkClusterMetastoresOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightSparkClusterMetastoresOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAmbari", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresAmbari\"}}]")]
        public virtual void PutAmbari(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresAmbari @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresAmbari)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHive", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresHive\"}}]")]
        public virtual void PutHive(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresHive @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresHive)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOozie", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresOozie\"}}]")]
        public virtual void PutOozie(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresOozie @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresOozie)}, new object[]{@value});
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

        [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresAmbariOutputReference\"}")]
        public virtual azurerm.HdinsightSparkCluster.HdinsightSparkClusterMetastoresAmbariOutputReference Ambari
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.HdinsightSparkClusterMetastoresAmbariOutputReference>()!;
        }

        [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresHiveOutputReference\"}")]
        public virtual azurerm.HdinsightSparkCluster.HdinsightSparkClusterMetastoresHiveOutputReference Hive
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.HdinsightSparkClusterMetastoresHiveOutputReference>()!;
        }

        [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresOozieOutputReference\"}")]
        public virtual azurerm.HdinsightSparkCluster.HdinsightSparkClusterMetastoresOozieOutputReference Oozie
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.HdinsightSparkClusterMetastoresOozieOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ambariInput", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresAmbari\"}", isOptional: true)]
        public virtual azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresAmbari? AmbariInput
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresAmbari?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hiveInput", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresHive\"}", isOptional: true)]
        public virtual azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresHive? HiveInput
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresHive?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oozieInput", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresOozie\"}", isOptional: true)]
        public virtual azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresOozie? OozieInput
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresOozie?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastores\"}", isOptional: true)]
        public virtual azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastores? InternalValue
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastores?>();
            set => SetInstanceProperty(value);
        }
    }
}
