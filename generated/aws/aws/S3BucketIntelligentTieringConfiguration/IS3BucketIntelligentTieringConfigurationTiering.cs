using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketIntelligentTieringConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketIntelligentTieringConfigurationTiering), fullyQualifiedName: "aws.s3BucketIntelligentTieringConfiguration.S3BucketIntelligentTieringConfigurationTiering")]
    public interface IS3BucketIntelligentTieringConfigurationTiering
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_intelligent_tiering_configuration#access_tier S3BucketIntelligentTieringConfiguration#access_tier}.</summary>
        [JsiiProperty(name: "accessTier", typeJson: "{\"primitive\":\"string\"}")]
        string AccessTier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_intelligent_tiering_configuration#days S3BucketIntelligentTieringConfiguration#days}.</summary>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}")]
        double Days
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketIntelligentTieringConfigurationTiering), fullyQualifiedName: "aws.s3BucketIntelligentTieringConfiguration.S3BucketIntelligentTieringConfigurationTiering")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketIntelligentTieringConfiguration.IS3BucketIntelligentTieringConfigurationTiering
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_intelligent_tiering_configuration#access_tier S3BucketIntelligentTieringConfiguration#access_tier}.</summary>
            [JsiiProperty(name: "accessTier", typeJson: "{\"primitive\":\"string\"}")]
            public string AccessTier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_intelligent_tiering_configuration#days S3BucketIntelligentTieringConfiguration#days}.</summary>
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}")]
            public double Days
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
