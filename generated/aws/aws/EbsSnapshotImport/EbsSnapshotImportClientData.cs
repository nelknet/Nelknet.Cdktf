using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EbsSnapshotImport
{
    [JsiiByValue(fqn: "aws.ebsSnapshotImport.EbsSnapshotImportClientData")]
    public class EbsSnapshotImportClientData : aws.EbsSnapshotImport.IEbsSnapshotImportClientData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#comment EbsSnapshotImport#comment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Comment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#upload_end EbsSnapshotImport#upload_end}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uploadEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UploadEnd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#upload_size EbsSnapshotImport#upload_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uploadSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UploadSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#upload_start EbsSnapshotImport#upload_start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uploadStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UploadStart
        {
            get;
            set;
        }
    }
}
