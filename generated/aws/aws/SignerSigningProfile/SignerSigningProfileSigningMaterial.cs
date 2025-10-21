using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SignerSigningProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.signerSigningProfile.SignerSigningProfileSigningMaterial")]
    public class SignerSigningProfileSigningMaterial : aws.SignerSigningProfile.ISignerSigningProfileSigningMaterial
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#certificate_arn SignerSigningProfile#certificate_arn}.</summary>
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateArn
        {
            get;
            set;
        }
    }
}
