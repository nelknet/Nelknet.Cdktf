using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketWebsiteConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketWebsiteConfigurationIndexDocument), fullyQualifiedName: "aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationIndexDocument")]
    public interface IS3BucketWebsiteConfigurationIndexDocument
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#suffix S3BucketWebsiteConfiguration#suffix}.</summary>
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
        string Suffix
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketWebsiteConfigurationIndexDocument), fullyQualifiedName: "aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationIndexDocument")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationIndexDocument
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#suffix S3BucketWebsiteConfiguration#suffix}.</summary>
            [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
            public string Suffix
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
