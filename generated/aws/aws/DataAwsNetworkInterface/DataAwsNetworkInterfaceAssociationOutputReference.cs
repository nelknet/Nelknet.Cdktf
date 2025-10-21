using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkInterface
{
    [JsiiClass(nativeType: typeof(aws.DataAwsNetworkInterface.DataAwsNetworkInterfaceAssociationOutputReference), fullyQualifiedName: "aws.dataAwsNetworkInterface.DataAwsNetworkInterfaceAssociationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsNetworkInterfaceAssociationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsNetworkInterfaceAssociationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsNetworkInterfaceAssociationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsNetworkInterfaceAssociationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allocationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllocationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "associationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "carrierIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CarrierIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerOwnedIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerOwnedIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipOwnerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpOwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicDnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicDnsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsNetworkInterface.DataAwsNetworkInterfaceAssociation\"}", isOptional: true)]
        public virtual aws.DataAwsNetworkInterface.IDataAwsNetworkInterfaceAssociation? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsNetworkInterface.IDataAwsNetworkInterfaceAssociation?>();
            set => SetInstanceProperty(value);
        }
    }
}
