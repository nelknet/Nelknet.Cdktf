using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SignerSigningProfile
{
    [JsiiInterface(nativeType: typeof(ISignerSigningProfileSigningMaterial), fullyQualifiedName: "aws.signerSigningProfile.SignerSigningProfileSigningMaterial")]
    public interface ISignerSigningProfileSigningMaterial
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#certificate_arn SignerSigningProfile#certificate_arn}.</summary>
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISignerSigningProfileSigningMaterial), fullyQualifiedName: "aws.signerSigningProfile.SignerSigningProfileSigningMaterial")]
        internal sealed class _Proxy : DeputyBase, aws.SignerSigningProfile.ISignerSigningProfileSigningMaterial
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#certificate_arn SignerSigningProfile#certificate_arn}.</summary>
            [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
