using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChimesdkvoiceVoiceProfileDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.chimesdkvoiceVoiceProfileDomain.ChimesdkvoiceVoiceProfileDomainServerSideEncryptionConfiguration")]
    public class ChimesdkvoiceVoiceProfileDomainServerSideEncryptionConfiguration : aws.ChimesdkvoiceVoiceProfileDomain.IChimesdkvoiceVoiceProfileDomainServerSideEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_voice_profile_domain#kms_key_arn ChimesdkvoiceVoiceProfileDomain#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public string KmsKeyArn
        {
            get;
            set;
        }
    }
}
