using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AcmpcaCertificateAuthority
{
    [JsiiClass(nativeType: typeof(aws.AcmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfigurationOutputReference), fullyQualifiedName: "aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AcmpcaCertificateAuthorityRevocationConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AcmpcaCertificateAuthorityRevocationConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AcmpcaCertificateAuthorityRevocationConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmpcaCertificateAuthorityRevocationConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCrlConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"}}]")]
        public virtual void PutCrlConfiguration(aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOcspConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfigurationOcspConfiguration\"}}]")]
        public virtual void PutOcspConfiguration(aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityRevocationConfigurationOcspConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityRevocationConfigurationOcspConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCrlConfiguration")]
        public virtual void ResetCrlConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOcspConfiguration")]
        public virtual void ResetOcspConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "crlConfiguration", typeJson: "{\"fqn\":\"aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfigurationOutputReference\"}")]
        public virtual aws.AcmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfigurationOutputReference CrlConfiguration
        {
            get => GetInstanceProperty<aws.AcmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "ocspConfiguration", typeJson: "{\"fqn\":\"aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfigurationOcspConfigurationOutputReference\"}")]
        public virtual aws.AcmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfigurationOcspConfigurationOutputReference OcspConfiguration
        {
            get => GetInstanceProperty<aws.AcmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfigurationOcspConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "crlConfigurationInput", typeJson: "{\"fqn\":\"aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"}", isOptional: true)]
        public virtual aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration? CrlConfigurationInput
        {
            get => GetInstanceProperty<aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ocspConfigurationInput", typeJson: "{\"fqn\":\"aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfigurationOcspConfiguration\"}", isOptional: true)]
        public virtual aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityRevocationConfigurationOcspConfiguration? OcspConfigurationInput
        {
            get => GetInstanceProperty<aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityRevocationConfigurationOcspConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfiguration\"}", isOptional: true)]
        public virtual aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityRevocationConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityRevocationConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
