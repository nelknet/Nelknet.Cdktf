using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2EmailIdentity
{
    [JsiiClass(nativeType: typeof(aws.Sesv2EmailIdentity.Sesv2EmailIdentityDkimSigningAttributesOutputReference), fullyQualifiedName: "aws.sesv2EmailIdentity.Sesv2EmailIdentityDkimSigningAttributesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Sesv2EmailIdentityDkimSigningAttributesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Sesv2EmailIdentityDkimSigningAttributesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Sesv2EmailIdentityDkimSigningAttributesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Sesv2EmailIdentityDkimSigningAttributesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDomainSigningPrivateKey")]
        public virtual void ResetDomainSigningPrivateKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomainSigningSelector")]
        public virtual void ResetDomainSigningSelector()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNextSigningKeyLength")]
        public virtual void ResetNextSigningKeyLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "currentSigningKeyLength", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentSigningKeyLength
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastKeyGenerationTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastKeyGenerationTimestamp
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
        [JsiiProperty(name: "domainSigningPrivateKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainSigningPrivateKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainSigningSelectorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainSigningSelectorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nextSigningKeyLengthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NextSigningKeyLengthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "domainSigningPrivateKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainSigningPrivateKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainSigningSelector", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainSigningSelector
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nextSigningKeyLength", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextSigningKeyLength
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sesv2EmailIdentity.Sesv2EmailIdentityDkimSigningAttributes\"}", isOptional: true)]
        public virtual aws.Sesv2EmailIdentity.ISesv2EmailIdentityDkimSigningAttributes? InternalValue
        {
            get => GetInstanceProperty<aws.Sesv2EmailIdentity.ISesv2EmailIdentityDkimSigningAttributes?>();
            set => SetInstanceProperty(value);
        }
    }
}
