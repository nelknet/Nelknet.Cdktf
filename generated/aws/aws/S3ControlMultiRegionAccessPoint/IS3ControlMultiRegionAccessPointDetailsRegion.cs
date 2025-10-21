using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlMultiRegionAccessPoint
{
    [JsiiInterface(nativeType: typeof(IS3ControlMultiRegionAccessPointDetailsRegion), fullyQualifiedName: "aws.s3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsRegion")]
    public interface IS3ControlMultiRegionAccessPointDetailsRegion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point#bucket S3ControlMultiRegionAccessPoint#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point#bucket_account_id S3ControlMultiRegionAccessPoint#bucket_account_id}.</summary>
        [JsiiProperty(name: "bucketAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketAccountId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ControlMultiRegionAccessPointDetailsRegion), fullyQualifiedName: "aws.s3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsRegion")]
        internal sealed class _Proxy : DeputyBase, aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetailsRegion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point#bucket S3ControlMultiRegionAccessPoint#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point#bucket_account_id S3ControlMultiRegionAccessPoint#bucket_account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucketAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketAccountId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
