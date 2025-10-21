using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSesv2EmailIdentity
{
    [JsiiClass(nativeType: typeof(aws.DataAwsSesv2EmailIdentity.DataAwsSesv2EmailIdentityDkimSigningAttributesOutputReference), fullyQualifiedName: "aws.dataAwsSesv2EmailIdentity.DataAwsSesv2EmailIdentityDkimSigningAttributesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsSesv2EmailIdentityDkimSigningAttributesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsSesv2EmailIdentityDkimSigningAttributesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsSesv2EmailIdentityDkimSigningAttributesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSesv2EmailIdentityDkimSigningAttributesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "currentSigningKeyLength", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentSigningKeyLength
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainSigningPrivateKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainSigningPrivateKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainSigningSelector", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainSigningSelector
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastKeyGenerationTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastKeyGenerationTimestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nextSigningKeyLength", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextSigningKeyLength
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signingAttributesOrigin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SigningAttributesOrigin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tokens", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tokens
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsSesv2EmailIdentity.DataAwsSesv2EmailIdentityDkimSigningAttributes\"}", isOptional: true)]
        public virtual aws.DataAwsSesv2EmailIdentity.IDataAwsSesv2EmailIdentityDkimSigningAttributes? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsSesv2EmailIdentity.IDataAwsSesv2EmailIdentityDkimSigningAttributes?>();
            set => SetInstanceProperty(value);
        }
    }
}
