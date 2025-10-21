using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionCustomErrorResponse), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionCustomErrorResponse")]
    public interface ICloudfrontDistributionCustomErrorResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#error_code CloudfrontDistribution#error_code}.</summary>
        [JsiiProperty(name: "errorCode", typeJson: "{\"primitive\":\"number\"}")]
        double ErrorCode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#error_caching_min_ttl CloudfrontDistribution#error_caching_min_ttl}.</summary>
        [JsiiProperty(name: "errorCachingMinTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ErrorCachingMinTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#response_code CloudfrontDistribution#response_code}.</summary>
        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ResponseCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#response_page_path CloudfrontDistribution#response_page_path}.</summary>
        [JsiiProperty(name: "responsePagePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponsePagePath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionCustomErrorResponse), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionCustomErrorResponse")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontDistribution.ICloudfrontDistributionCustomErrorResponse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#error_code CloudfrontDistribution#error_code}.</summary>
            [JsiiProperty(name: "errorCode", typeJson: "{\"primitive\":\"number\"}")]
            public double ErrorCode
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#error_caching_min_ttl CloudfrontDistribution#error_caching_min_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "errorCachingMinTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ErrorCachingMinTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#response_code CloudfrontDistribution#response_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ResponseCode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#response_page_path CloudfrontDistribution#response_page_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responsePagePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponsePagePath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
