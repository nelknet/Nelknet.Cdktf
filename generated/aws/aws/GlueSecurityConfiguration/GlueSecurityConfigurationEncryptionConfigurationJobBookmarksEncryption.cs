using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueSecurityConfiguration
{
    [JsiiByValue(fqn: "aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption")]
    public class GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption : aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_security_configuration#job_bookmarks_encryption_mode GlueSecurityConfiguration#job_bookmarks_encryption_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jobBookmarksEncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JobBookmarksEncryptionMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_security_configuration#kms_key_arn GlueSecurityConfiguration#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }
    }
}
