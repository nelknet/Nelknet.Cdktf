using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EbsSnapshotImport
{
    [JsiiInterface(nativeType: typeof(IEbsSnapshotImportDiskContainer), fullyQualifiedName: "aws.ebsSnapshotImport.EbsSnapshotImportDiskContainer")]
    public interface IEbsSnapshotImportDiskContainer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#format EbsSnapshotImport#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        string Format
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#description EbsSnapshotImport#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#url EbsSnapshotImport#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Url
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#user_bucket EbsSnapshotImport#user_bucket}
        /// </remarks>
        [JsiiProperty(name: "userBucket", typeJson: "{\"fqn\":\"aws.ebsSnapshotImport.EbsSnapshotImportDiskContainerUserBucket\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EbsSnapshotImport.IEbsSnapshotImportDiskContainerUserBucket? UserBucket
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEbsSnapshotImportDiskContainer), fullyQualifiedName: "aws.ebsSnapshotImport.EbsSnapshotImportDiskContainer")]
        internal sealed class _Proxy : DeputyBase, aws.EbsSnapshotImport.IEbsSnapshotImportDiskContainer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#format EbsSnapshotImport#format}.</summary>
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
            public string Format
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#description EbsSnapshotImport#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#url EbsSnapshotImport#url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Url
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>user_bucket block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#user_bucket EbsSnapshotImport#user_bucket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userBucket", typeJson: "{\"fqn\":\"aws.ebsSnapshotImport.EbsSnapshotImportDiskContainerUserBucket\"}", isOptional: true)]
            public aws.EbsSnapshotImport.IEbsSnapshotImportDiskContainerUserBucket? UserBucket
            {
                get => GetInstanceProperty<aws.EbsSnapshotImport.IEbsSnapshotImportDiskContainerUserBucket?>();
            }
        }
    }
}
