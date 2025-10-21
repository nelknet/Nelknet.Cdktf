using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EbsSnapshotImport
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ebsSnapshotImport.EbsSnapshotImportDiskContainer")]
    public class EbsSnapshotImportDiskContainer : aws.EbsSnapshotImport.IEbsSnapshotImportDiskContainer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#format EbsSnapshotImport#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public string Format
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#description EbsSnapshotImport#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#url EbsSnapshotImport#url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Url
        {
            get;
            set;
        }

        /// <summary>user_bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#user_bucket EbsSnapshotImport#user_bucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userBucket", typeJson: "{\"fqn\":\"aws.ebsSnapshotImport.EbsSnapshotImportDiskContainerUserBucket\"}", isOptional: true)]
        public aws.EbsSnapshotImport.IEbsSnapshotImportDiskContainerUserBucket? UserBucket
        {
            get;
            set;
        }
    }
}
