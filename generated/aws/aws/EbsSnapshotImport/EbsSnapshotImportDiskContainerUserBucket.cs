using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EbsSnapshotImport
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ebsSnapshotImport.EbsSnapshotImportDiskContainerUserBucket")]
    public class EbsSnapshotImportDiskContainerUserBucket : aws.EbsSnapshotImport.IEbsSnapshotImportDiskContainerUserBucket
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#s3_bucket EbsSnapshotImport#s3_bucket}.</summary>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#s3_key EbsSnapshotImport#s3_key}.</summary>
        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Key
        {
            get;
            set;
        }
    }
}
