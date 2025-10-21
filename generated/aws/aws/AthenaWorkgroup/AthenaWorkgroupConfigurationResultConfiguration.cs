using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiByValue(fqn: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationResultConfiguration")]
    public class AthenaWorkgroupConfigurationResultConfiguration : aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationResultConfiguration
    {
        /// <summary>acl_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#acl_configuration AthenaWorkgroup#acl_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aclConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationResultConfigurationAclConfiguration\"}", isOptional: true)]
        public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationResultConfigurationAclConfiguration? AclConfiguration
        {
            get;
            set;
        }

        /// <summary>encryption_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#encryption_configuration AthenaWorkgroup#encryption_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration\"}", isOptional: true)]
        public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration? EncryptionConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#expected_bucket_owner AthenaWorkgroup#expected_bucket_owner}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expectedBucketOwner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExpectedBucketOwner
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#output_location AthenaWorkgroup#output_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutputLocation
        {
            get;
            set;
        }
    }
}
