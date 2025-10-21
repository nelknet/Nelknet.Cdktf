using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcIpamPools
{
    [JsiiClass(nativeType: typeof(aws.DataAwsVpcIpamPools.DataAwsVpcIpamPoolsIpamPoolsOutputReference), fullyQualifiedName: "aws.dataAwsVpcIpamPools.DataAwsVpcIpamPoolsIpamPoolsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsVpcIpamPoolsIpamPoolsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsVpcIpamPoolsIpamPoolsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsVpcIpamPoolsIpamPoolsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsVpcIpamPoolsIpamPoolsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addressFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressFamily
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "allocationDefaultNetmaskLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AllocationDefaultNetmaskLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "allocationMaxNetmaskLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AllocationMaxNetmaskLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "allocationMinNetmaskLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AllocationMinNetmaskLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "allocationResourceTags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap AllocationResourceTags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoImport", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AutoImport
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "awsService", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsService
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipamScopeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpamScopeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipamScopeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpamScopeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Locale
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "poolDepth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PoolDepth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "publiclyAdvertisable", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable PubliclyAdvertisable
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "sourceIpamPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceIpamPoolId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsVpcIpamPools.DataAwsVpcIpamPoolsIpamPools\"}", isOptional: true)]
        public virtual aws.DataAwsVpcIpamPools.IDataAwsVpcIpamPoolsIpamPools? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsVpcIpamPools.IDataAwsVpcIpamPoolsIpamPools?>();
            set => SetInstanceProperty(value);
        }
    }
}
