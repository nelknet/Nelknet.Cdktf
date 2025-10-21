using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EbsSnapshotImport
{
    [JsiiInterface(nativeType: typeof(IEbsSnapshotImportDiskContainerUserBucket), fullyQualifiedName: "aws.ebsSnapshotImport.EbsSnapshotImportDiskContainerUserBucket")]
    public interface IEbsSnapshotImportDiskContainerUserBucket
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#s3_bucket EbsSnapshotImport#s3_bucket}.</summary>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        string S3Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#s3_key EbsSnapshotImport#s3_key}.</summary>
        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}")]
        string S3Key
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEbsSnapshotImportDiskContainerUserBucket), fullyQualifiedName: "aws.ebsSnapshotImport.EbsSnapshotImportDiskContainerUserBucket")]
        internal sealed class _Proxy : DeputyBase, aws.EbsSnapshotImport.IEbsSnapshotImportDiskContainerUserBucket
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#s3_bucket EbsSnapshotImport#s3_bucket}.</summary>
            [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#s3_key EbsSnapshotImport#s3_key}.</summary>
            [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Key
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
