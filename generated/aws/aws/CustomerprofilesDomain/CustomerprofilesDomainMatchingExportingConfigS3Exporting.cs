using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.customerprofilesDomain.CustomerprofilesDomainMatchingExportingConfigS3Exporting")]
    public class CustomerprofilesDomainMatchingExportingConfigS3Exporting : aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingExportingConfigS3Exporting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#s3_bucket_name CustomerprofilesDomain#s3_bucket_name}.</summary>
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string S3BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#s3_key_name CustomerprofilesDomain#s3_key_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3KeyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3KeyName
        {
            get;
            set;
        }
    }
}
