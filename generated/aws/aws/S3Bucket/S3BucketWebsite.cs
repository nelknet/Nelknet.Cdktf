using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiByValue(fqn: "aws.s3Bucket.S3BucketWebsite")]
    public class S3BucketWebsite : aws.S3Bucket.IS3BucketWebsite
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#error_document S3Bucket#error_document}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errorDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ErrorDocument
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#index_document S3Bucket#index_document}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IndexDocument
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#redirect_all_requests_to S3Bucket#redirect_all_requests_to}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirectAllRequestsTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RedirectAllRequestsTo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#routing_rules S3Bucket#routing_rules}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routingRules", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoutingRules
        {
            get;
            set;
        }
    }
}
