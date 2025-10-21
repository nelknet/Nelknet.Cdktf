using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EbsSnapshotImport
{
    [JsiiInterface(nativeType: typeof(IEbsSnapshotImportClientData), fullyQualifiedName: "aws.ebsSnapshotImport.EbsSnapshotImportClientData")]
    public interface IEbsSnapshotImportClientData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#comment EbsSnapshotImport#comment}.</summary>
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#upload_end EbsSnapshotImport#upload_end}.</summary>
        [JsiiProperty(name: "uploadEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UploadEnd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#upload_size EbsSnapshotImport#upload_size}.</summary>
        [JsiiProperty(name: "uploadSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UploadSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#upload_start EbsSnapshotImport#upload_start}.</summary>
        [JsiiProperty(name: "uploadStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UploadStart
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEbsSnapshotImportClientData), fullyQualifiedName: "aws.ebsSnapshotImport.EbsSnapshotImportClientData")]
        internal sealed class _Proxy : DeputyBase, aws.EbsSnapshotImport.IEbsSnapshotImportClientData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#comment EbsSnapshotImport#comment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#upload_end EbsSnapshotImport#upload_end}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uploadEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UploadEnd
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#upload_size EbsSnapshotImport#upload_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uploadSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UploadSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#upload_start EbsSnapshotImport#upload_start}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uploadStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UploadStart
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
