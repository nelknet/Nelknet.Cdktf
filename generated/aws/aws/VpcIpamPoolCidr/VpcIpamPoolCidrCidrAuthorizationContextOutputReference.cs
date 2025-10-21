using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcIpamPoolCidr
{
    [JsiiClass(nativeType: typeof(aws.VpcIpamPoolCidr.VpcIpamPoolCidrCidrAuthorizationContextOutputReference), fullyQualifiedName: "aws.vpcIpamPoolCidr.VpcIpamPoolCidrCidrAuthorizationContextOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpcIpamPoolCidrCidrAuthorizationContextOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpcIpamPoolCidrCidrAuthorizationContextOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VpcIpamPoolCidrCidrAuthorizationContextOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcIpamPoolCidrCidrAuthorizationContextOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMessage")]
        public virtual void ResetMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSignature")]
        public virtual void ResetSignature()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "messageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signatureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SignatureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Message
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "signature", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Signature
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.vpcIpamPoolCidr.VpcIpamPoolCidrCidrAuthorizationContext\"}", isOptional: true)]
        public virtual aws.VpcIpamPoolCidr.IVpcIpamPoolCidrCidrAuthorizationContext? InternalValue
        {
            get => GetInstanceProperty<aws.VpcIpamPoolCidr.IVpcIpamPoolCidrCidrAuthorizationContext?>();
            set => SetInstanceProperty(value);
        }
    }
}
