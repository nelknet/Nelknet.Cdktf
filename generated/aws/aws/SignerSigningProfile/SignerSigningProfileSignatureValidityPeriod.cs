using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SignerSigningProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.signerSigningProfile.SignerSigningProfileSignatureValidityPeriod")]
    public class SignerSigningProfileSignatureValidityPeriod : aws.SignerSigningProfile.ISignerSigningProfileSignatureValidityPeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#type SignerSigningProfile#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#value SignerSigningProfile#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }
    }
}
