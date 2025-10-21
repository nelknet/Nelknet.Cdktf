using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueSecurityConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfiguration")]
    public class GlueSecurityConfigurationEncryptionConfiguration : aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfiguration
    {
        /// <summary>cloudwatch_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_security_configuration#cloudwatch_encryption GlueSecurityConfiguration#cloudwatch_encryption}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchEncryption", typeJson: "{\"fqn\":\"aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption\"}")]
        public aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption CloudwatchEncryption
        {
            get;
            set;
        }

        /// <summary>job_bookmarks_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_security_configuration#job_bookmarks_encryption GlueSecurityConfiguration#job_bookmarks_encryption}
        /// </remarks>
        [JsiiProperty(name: "jobBookmarksEncryption", typeJson: "{\"fqn\":\"aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption\"}")]
        public aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption JobBookmarksEncryption
        {
            get;
            set;
        }

        /// <summary>s3_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_security_configuration#s3_encryption GlueSecurityConfiguration#s3_encryption}
        /// </remarks>
        [JsiiProperty(name: "s3Encryption", typeJson: "{\"fqn\":\"aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationS3Encryption\"}")]
        public aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption S3Encryption
        {
            get;
            set;
        }
    }
}
