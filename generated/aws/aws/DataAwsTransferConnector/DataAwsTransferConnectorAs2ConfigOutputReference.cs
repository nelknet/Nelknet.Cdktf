using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsTransferConnector
{
    [JsiiClass(nativeType: typeof(aws.DataAwsTransferConnector.DataAwsTransferConnectorAs2ConfigOutputReference), fullyQualifiedName: "aws.dataAwsTransferConnector.DataAwsTransferConnectorAs2ConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsTransferConnectorAs2ConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsTransferConnectorAs2ConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsTransferConnectorAs2ConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsTransferConnectorAs2ConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "basicAuthSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BasicAuthSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Compression
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localProfileId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalProfileId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mdnResponse", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MdnResponse
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mdnSigningAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MdnSigningAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "messageSubject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MessageSubject
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "partnerProfileId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerProfileId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "singingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SingingAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsTransferConnector.DataAwsTransferConnectorAs2Config\"}", isOptional: true)]
        public virtual aws.DataAwsTransferConnector.IDataAwsTransferConnectorAs2Config? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsTransferConnector.IDataAwsTransferConnectorAs2Config?>();
            set => SetInstanceProperty(value);
        }
    }
}
