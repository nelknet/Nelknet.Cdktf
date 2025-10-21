using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcIpams
{
    [JsiiClass(nativeType: typeof(aws.DataAwsVpcIpams.DataAwsVpcIpamsIpamsOutputReference), fullyQualifiedName: "aws.dataAwsVpcIpams.DataAwsVpcIpamsIpamsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsVpcIpamsIpamsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsVpcIpamsIpamsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsVpcIpamsIpamsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsVpcIpamsIpamsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultResourceDiscoveryAssociationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultResourceDiscoveryAssociationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultResourceDiscoveryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultResourceDiscoveryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enablePrivateGua", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable EnablePrivateGua
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipamRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpamRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operatingRegions", typeJson: "{\"fqn\":\"aws.dataAwsVpcIpams.DataAwsVpcIpamsIpamsOperatingRegionsList\"}")]
        public virtual aws.DataAwsVpcIpams.DataAwsVpcIpamsIpamsOperatingRegionsList OperatingRegions
        {
            get => GetInstanceProperty<aws.DataAwsVpcIpams.DataAwsVpcIpamsIpamsOperatingRegionsList>()!;
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateDefaultScopeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateDefaultScopeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicDefaultScopeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicDefaultScopeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceDiscoveryAssociationCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ResourceDiscoveryAssociationCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scopeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScopeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stateMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StateMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsVpcIpams.DataAwsVpcIpamsIpams\"}", isOptional: true)]
        public virtual aws.DataAwsVpcIpams.IDataAwsVpcIpamsIpams? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsVpcIpams.IDataAwsVpcIpamsIpams?>();
            set => SetInstanceProperty(value);
        }
    }
}
