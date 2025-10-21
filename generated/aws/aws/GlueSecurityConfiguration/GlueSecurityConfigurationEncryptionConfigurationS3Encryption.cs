using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueSecurityConfiguration
{
    [JsiiByValue(fqn: "aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationS3Encryption")]
    public class GlueSecurityConfigurationEncryptionConfigurationS3Encryption : aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_security_configuration#kms_key_arn GlueSecurityConfiguration#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_security_configuration#s3_encryption_mode GlueSecurityConfiguration#s3_encryption_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3EncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3EncryptionMode
        {
            get;
            set;
        }
    }
}
