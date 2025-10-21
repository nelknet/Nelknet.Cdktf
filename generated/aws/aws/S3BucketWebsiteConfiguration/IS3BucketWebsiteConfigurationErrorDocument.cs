using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketWebsiteConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketWebsiteConfigurationErrorDocument), fullyQualifiedName: "aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationErrorDocument")]
    public interface IS3BucketWebsiteConfigurationErrorDocument
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#key S3BucketWebsiteConfiguration#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketWebsiteConfigurationErrorDocument), fullyQualifiedName: "aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationErrorDocument")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationErrorDocument
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#key S3BucketWebsiteConfiguration#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
