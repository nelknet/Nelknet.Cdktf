using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontDistribution.CloudfrontDistributionOrigin")]
    public class CloudfrontDistributionOrigin : aws.CloudfrontDistribution.ICloudfrontDistributionOrigin
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#domain_name CloudfrontDistribution#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_id CloudfrontDistribution#origin_id}.</summary>
        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
        public string OriginId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#connection_attempts CloudfrontDistribution#connection_attempts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectionAttempts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#connection_timeout CloudfrontDistribution#connection_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectionTimeout
        {
            get;
            set;
        }

        private object? _customHeader;

        /// <summary>custom_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#custom_header CloudfrontDistribution#custom_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomHeader
        {
            get => _customHeader;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomHeader[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomHeader).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customHeader = value;
            }
        }

        /// <summary>custom_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#custom_origin_config CloudfrontDistribution#custom_origin_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customOriginConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomOriginConfig\"}", isOptional: true)]
        public aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomOriginConfig? CustomOriginConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_access_control_id CloudfrontDistribution#origin_access_control_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originAccessControlId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginAccessControlId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_path CloudfrontDistribution#origin_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginPath
        {
            get;
            set;
        }

        /// <summary>origin_shield block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_shield CloudfrontDistribution#origin_shield}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "originShield", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginOriginShield\"}", isOptional: true)]
        public aws.CloudfrontDistribution.ICloudfrontDistributionOriginOriginShield? OriginShield
        {
            get;
            set;
        }

        /// <summary>s3_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#s3_origin_config CloudfrontDistribution#s3_origin_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3OriginConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginS3OriginConfig\"}", isOptional: true)]
        public aws.CloudfrontDistribution.ICloudfrontDistributionOriginS3OriginConfig? S3OriginConfig
        {
            get;
            set;
        }

        /// <summary>vpc_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#vpc_origin_config CloudfrontDistribution#vpc_origin_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcOriginConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginVpcOriginConfig\"}", isOptional: true)]
        public aws.CloudfrontDistribution.ICloudfrontDistributionOriginVpcOriginConfig? VpcOriginConfig
        {
            get;
            set;
        }
    }
}
