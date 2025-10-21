using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SignerSigningProfile
{
    [JsiiInterface(nativeType: typeof(ISignerSigningProfileSignatureValidityPeriod), fullyQualifiedName: "aws.signerSigningProfile.SignerSigningProfileSignatureValidityPeriod")]
    public interface ISignerSigningProfileSignatureValidityPeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#type SignerSigningProfile#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#value SignerSigningProfile#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISignerSigningProfileSignatureValidityPeriod), fullyQualifiedName: "aws.signerSigningProfile.SignerSigningProfileSignatureValidityPeriod")]
        internal sealed class _Proxy : DeputyBase, aws.SignerSigningProfile.ISignerSigningProfileSignatureValidityPeriod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#type SignerSigningProfile#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#value SignerSigningProfile#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
