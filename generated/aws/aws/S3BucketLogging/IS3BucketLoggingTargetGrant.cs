using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketLogging
{
    [JsiiInterface(nativeType: typeof(IS3BucketLoggingTargetGrant), fullyQualifiedName: "aws.s3BucketLogging.S3BucketLoggingTargetGrant")]
    public interface IS3BucketLoggingTargetGrant
    {
        /// <summary>grantee block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#grantee S3BucketLoggingA#grantee}
        /// </remarks>
        [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetGrantGrantee\"}")]
        aws.S3BucketLogging.IS3BucketLoggingTargetGrantGrantee Grantee
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#permission S3BucketLoggingA#permission}.</summary>
        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        string Permission
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketLoggingTargetGrant), fullyQualifiedName: "aws.s3BucketLogging.S3BucketLoggingTargetGrant")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketLogging.IS3BucketLoggingTargetGrant
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grantee block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#grantee S3BucketLoggingA#grantee}
            /// </remarks>
            [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetGrantGrantee\"}")]
            public aws.S3BucketLogging.IS3BucketLoggingTargetGrantGrantee Grantee
            {
                get => GetInstanceProperty<aws.S3BucketLogging.IS3BucketLoggingTargetGrantGrantee>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#permission S3BucketLoggingA#permission}.</summary>
            [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
            public string Permission
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
