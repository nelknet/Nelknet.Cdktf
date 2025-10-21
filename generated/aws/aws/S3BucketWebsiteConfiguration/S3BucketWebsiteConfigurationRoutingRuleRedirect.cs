using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketWebsiteConfiguration
{
    [JsiiByValue(fqn: "aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRuleRedirect")]
    public class S3BucketWebsiteConfigurationRoutingRuleRedirect : aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRuleRedirect
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#host_name S3BucketWebsiteConfiguration#host_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#http_redirect_code S3BucketWebsiteConfiguration#http_redirect_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpRedirectCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpRedirectCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#protocol S3BucketWebsiteConfiguration#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#replace_key_prefix_with S3BucketWebsiteConfiguration#replace_key_prefix_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replaceKeyPrefixWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplaceKeyPrefixWith
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#replace_key_with S3BucketWebsiteConfiguration#replace_key_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replaceKeyWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplaceKeyWith
        {
            get;
            set;
        }
    }
}
