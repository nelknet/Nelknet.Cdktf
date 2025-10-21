using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketWebsiteConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRule")]
    public class S3BucketWebsiteConfigurationRoutingRule : aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRule
    {
        /// <summary>redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#redirect S3BucketWebsiteConfiguration#redirect}
        /// </remarks>
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRuleRedirect\"}")]
        public aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRuleRedirect Redirect
        {
            get;
            set;
        }

        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#condition S3BucketWebsiteConfiguration#condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRuleCondition\"}", isOptional: true)]
        public aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRuleCondition? Condition
        {
            get;
            set;
        }
    }
}
