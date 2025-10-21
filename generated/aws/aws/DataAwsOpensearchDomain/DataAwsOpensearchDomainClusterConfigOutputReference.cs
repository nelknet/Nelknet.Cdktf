using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsOpensearchDomain
{
    [JsiiClass(nativeType: typeof(aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfigOutputReference), fullyQualifiedName: "aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsOpensearchDomainClusterConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsOpensearchDomainClusterConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsOpensearchDomainClusterConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOpensearchDomainClusterConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "coldStorageOptions", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfigColdStorageOptionsList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfigColdStorageOptionsList ColdStorageOptions
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfigColdStorageOptionsList>()!;
        }

        [JsiiProperty(name: "dedicatedMasterCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DedicatedMasterCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dedicatedMasterEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DedicatedMasterEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "dedicatedMasterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DedicatedMasterType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "multiAzWithStandbyEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable MultiAzWithStandbyEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "nodeOptions", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfigNodeOptionsList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfigNodeOptionsList NodeOptions
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfigNodeOptionsList>()!;
        }

        [JsiiProperty(name: "warmCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WarmCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "warmEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable WarmEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "warmType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WarmType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zoneAwarenessConfig", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfigZoneAwarenessConfigList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfigZoneAwarenessConfigList ZoneAwarenessConfig
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfigZoneAwarenessConfigList>()!;
        }

        [JsiiProperty(name: "zoneAwarenessEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ZoneAwarenessEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfig\"}", isOptional: true)]
        public virtual aws.DataAwsOpensearchDomain.IDataAwsOpensearchDomainClusterConfig? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.IDataAwsOpensearchDomainClusterConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
