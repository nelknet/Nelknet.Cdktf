using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChimesdkvoiceVoiceProfileDomain
{
    [JsiiInterface(nativeType: typeof(IChimesdkvoiceVoiceProfileDomainServerSideEncryptionConfiguration), fullyQualifiedName: "aws.chimesdkvoiceVoiceProfileDomain.ChimesdkvoiceVoiceProfileDomainServerSideEncryptionConfiguration")]
    public interface IChimesdkvoiceVoiceProfileDomainServerSideEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_voice_profile_domain#kms_key_arn ChimesdkvoiceVoiceProfileDomain#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        string KmsKeyArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IChimesdkvoiceVoiceProfileDomainServerSideEncryptionConfiguration), fullyQualifiedName: "aws.chimesdkvoiceVoiceProfileDomain.ChimesdkvoiceVoiceProfileDomainServerSideEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ChimesdkvoiceVoiceProfileDomain.IChimesdkvoiceVoiceProfileDomainServerSideEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_voice_profile_domain#kms_key_arn ChimesdkvoiceVoiceProfileDomain#kms_key_arn}.</summary>
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
            public string KmsKeyArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
