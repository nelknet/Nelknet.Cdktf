using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiInterface(nativeType: typeof(IS3BucketLogging), fullyQualifiedName: "aws.s3Bucket.S3BucketLogging")]
    public interface IS3BucketLogging
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#target_bucket S3Bucket#target_bucket}.</summary>
        [JsiiProperty(name: "targetBucket", typeJson: "{\"primitive\":\"string\"}")]
        string TargetBucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#target_prefix S3Bucket#target_prefix}.</summary>
        [JsiiProperty(name: "targetPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketLogging), fullyQualifiedName: "aws.s3Bucket.S3BucketLogging")]
        internal sealed class _Proxy : DeputyBase, aws.S3Bucket.IS3BucketLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#target_bucket S3Bucket#target_bucket}.</summary>
            [JsiiProperty(name: "targetBucket", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetBucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#target_prefix S3Bucket#target_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
