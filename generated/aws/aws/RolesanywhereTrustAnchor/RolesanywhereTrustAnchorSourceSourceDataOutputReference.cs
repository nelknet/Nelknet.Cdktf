using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RolesanywhereTrustAnchor
{
    [JsiiClass(nativeType: typeof(aws.RolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceSourceDataOutputReference), fullyQualifiedName: "aws.rolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceSourceDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RolesanywhereTrustAnchorSourceSourceDataOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RolesanywhereTrustAnchorSourceSourceDataOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected RolesanywhereTrustAnchorSourceSourceDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RolesanywhereTrustAnchorSourceSourceDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAcmPcaArn")]
        public virtual void ResetAcmPcaArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetX509CertificateData")]
        public virtual void ResetX509CertificateData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "acmPcaArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AcmPcaArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "x509CertificateDataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? X509CertificateDataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "acmPcaArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcmPcaArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "x509CertificateData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string X509CertificateData
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.rolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceSourceData\"}", isOptional: true)]
        public virtual aws.RolesanywhereTrustAnchor.IRolesanywhereTrustAnchorSourceSourceData? InternalValue
        {
            get => GetInstanceProperty<aws.RolesanywhereTrustAnchor.IRolesanywhereTrustAnchorSourceSourceData?>();
            set => SetInstanceProperty(value);
        }
    }
}
