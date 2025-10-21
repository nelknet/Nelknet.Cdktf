using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketWebsiteConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationErrorDocument")]
    public class S3BucketWebsiteConfigurationErrorDocument : aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationErrorDocument
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#key S3BucketWebsiteConfiguration#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }
    }
}
