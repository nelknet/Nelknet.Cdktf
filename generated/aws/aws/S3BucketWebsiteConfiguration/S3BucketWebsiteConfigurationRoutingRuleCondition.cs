using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketWebsiteConfiguration
{
    [JsiiByValue(fqn: "aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRuleCondition")]
    public class S3BucketWebsiteConfigurationRoutingRuleCondition : aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRuleCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#http_error_code_returned_equals S3BucketWebsiteConfiguration#http_error_code_returned_equals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpErrorCodeReturnedEquals", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpErrorCodeReturnedEquals
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#key_prefix_equals S3BucketWebsiteConfiguration#key_prefix_equals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyPrefixEquals", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyPrefixEquals
        {
            get;
            set;
        }
    }
}
