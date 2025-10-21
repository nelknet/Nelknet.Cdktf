using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2PublicIpv4Pool
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEc2PublicIpv4Pool.DataAwsEc2PublicIpv4PoolPoolAddressRangesOutputReference), fullyQualifiedName: "aws.dataAwsEc2PublicIpv4Pool.DataAwsEc2PublicIpv4PoolPoolAddressRangesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsEc2PublicIpv4PoolPoolAddressRangesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsEc2PublicIpv4PoolPoolAddressRangesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsEc2PublicIpv4PoolPoolAddressRangesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2PublicIpv4PoolPoolAddressRangesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addressCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AddressCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableAddressCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableAddressCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "firstAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsEc2PublicIpv4Pool.DataAwsEc2PublicIpv4PoolPoolAddressRanges\"}", isOptional: true)]
        public virtual aws.DataAwsEc2PublicIpv4Pool.IDataAwsEc2PublicIpv4PoolPoolAddressRanges? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsEc2PublicIpv4Pool.IDataAwsEc2PublicIpv4PoolPoolAddressRanges?>();
            set => SetInstanceProperty(value);
        }
    }
}
