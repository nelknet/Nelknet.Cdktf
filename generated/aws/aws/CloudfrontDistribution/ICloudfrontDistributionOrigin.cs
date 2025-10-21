using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOrigin), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionOrigin")]
    public interface ICloudfrontDistributionOrigin
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#domain_name CloudfrontDistribution#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_id CloudfrontDistribution#origin_id}.</summary>
        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
        string OriginId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#connection_attempts CloudfrontDistribution#connection_attempts}.</summary>
        [JsiiProperty(name: "connectionAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConnectionAttempts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#connection_timeout CloudfrontDistribution#connection_timeout}.</summary>
        [JsiiProperty(name: "connectionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConnectionTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#custom_header CloudfrontDistribution#custom_header}
        /// </remarks>
        [JsiiProperty(name: "customHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#custom_origin_config CloudfrontDistribution#custom_origin_config}
        /// </remarks>
        [JsiiProperty(name: "customOriginConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomOriginConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomOriginConfig? CustomOriginConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_access_control_id CloudfrontDistribution#origin_access_control_id}.</summary>
        [JsiiProperty(name: "originAccessControlId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginAccessControlId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_path CloudfrontDistribution#origin_path}.</summary>
        [JsiiProperty(name: "originPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>origin_shield block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_shield CloudfrontDistribution#origin_shield}
        /// </remarks>
        [JsiiProperty(name: "originShield", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginOriginShield\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudfrontDistribution.ICloudfrontDistributionOriginOriginShield? OriginShield
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#s3_origin_config CloudfrontDistribution#s3_origin_config}
        /// </remarks>
        [JsiiProperty(name: "s3OriginConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginS3OriginConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudfrontDistribution.ICloudfrontDistributionOriginS3OriginConfig? S3OriginConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#vpc_origin_config CloudfrontDistribution#vpc_origin_config}
        /// </remarks>
        [JsiiProperty(name: "vpcOriginConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginVpcOriginConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudfrontDistribution.ICloudfrontDistributionOriginVpcOriginConfig? VpcOriginConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOrigin), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionOrigin")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontDistribution.ICloudfrontDistributionOrigin
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#domain_name CloudfrontDistribution#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_id CloudfrontDistribution#origin_id}.</summary>
            [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
            public string OriginId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#connection_attempts CloudfrontDistribution#connection_attempts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConnectionAttempts
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#connection_timeout CloudfrontDistribution#connection_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConnectionTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>custom_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#custom_header CloudfrontDistribution#custom_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomHeader
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_origin_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#custom_origin_config CloudfrontDistribution#custom_origin_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customOriginConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomOriginConfig\"}", isOptional: true)]
            public aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomOriginConfig? CustomOriginConfig
            {
                get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomOriginConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_access_control_id CloudfrontDistribution#origin_access_control_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originAccessControlId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginAccessControlId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_path CloudfrontDistribution#origin_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>origin_shield block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_shield CloudfrontDistribution#origin_shield}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originShield", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginOriginShield\"}", isOptional: true)]
            public aws.CloudfrontDistribution.ICloudfrontDistributionOriginOriginShield? OriginShield
            {
                get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionOriginOriginShield?>();
            }

            /// <summary>s3_origin_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#s3_origin_config CloudfrontDistribution#s3_origin_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3OriginConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginS3OriginConfig\"}", isOptional: true)]
            public aws.CloudfrontDistribution.ICloudfrontDistributionOriginS3OriginConfig? S3OriginConfig
            {
                get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionOriginS3OriginConfig?>();
            }

            /// <summary>vpc_origin_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#vpc_origin_config CloudfrontDistribution#vpc_origin_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcOriginConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginVpcOriginConfig\"}", isOptional: true)]
            public aws.CloudfrontDistribution.ICloudfrontDistributionOriginVpcOriginConfig? VpcOriginConfig
            {
                get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionOriginVpcOriginConfig?>();
            }
        }
    }
}
