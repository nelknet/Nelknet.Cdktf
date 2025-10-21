using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterMetastoresOutputReference), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HdinsightHbaseClusterMetastoresOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HdinsightHbaseClusterMetastoresOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HdinsightHbaseClusterMetastoresOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightHbaseClusterMetastoresOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAmbari", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresAmbari\"}}]")]
        public virtual void PutAmbari(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresAmbari @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresAmbari)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHive", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresHive\"}}]")]
        public virtual void PutHive(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresHive @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresHive)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOozie", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresOozie\"}}]")]
        public virtual void PutOozie(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresOozie @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresOozie)}, new object[]{@value});
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

        [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresAmbariOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterMetastoresAmbariOutputReference Ambari
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterMetastoresAmbariOutputReference>()!;
        }

        [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresHiveOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterMetastoresHiveOutputReference Hive
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterMetastoresHiveOutputReference>()!;
        }

        [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresOozieOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterMetastoresOozieOutputReference Oozie
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterMetastoresOozieOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ambariInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresAmbari\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresAmbari? AmbariInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresAmbari?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hiveInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresHive\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresHive? HiveInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresHive?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oozieInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresOozie\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresOozie? OozieInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresOozie?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastores\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastores? InternalValue
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastores?>();
            set => SetInstanceProperty(value);
        }
    }
}
