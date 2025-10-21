using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxDataRepositoryAssociation
{
    [JsiiInterface(nativeType: typeof(IFsxDataRepositoryAssociationS3), fullyQualifiedName: "aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3")]
    public interface IFsxDataRepositoryAssociationS3
    {
        /// <summary>auto_export_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#auto_export_policy FsxDataRepositoryAssociation#auto_export_policy}
        /// </remarks>
        [JsiiProperty(name: "autoExportPolicy", typeJson: "{\"fqn\":\"aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoExportPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoExportPolicy? AutoExportPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>auto_import_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#auto_import_policy FsxDataRepositoryAssociation#auto_import_policy}
        /// </remarks>
        [JsiiProperty(name: "autoImportPolicy", typeJson: "{\"fqn\":\"aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoImportPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoImportPolicy? AutoImportPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxDataRepositoryAssociationS3), fullyQualifiedName: "aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3")]
        internal sealed class _Proxy : DeputyBase, aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>auto_export_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#auto_export_policy FsxDataRepositoryAssociation#auto_export_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoExportPolicy", typeJson: "{\"fqn\":\"aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoExportPolicy\"}", isOptional: true)]
            public aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoExportPolicy? AutoExportPolicy
            {
                get => GetInstanceProperty<aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoExportPolicy?>();
            }

            /// <summary>auto_import_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#auto_import_policy FsxDataRepositoryAssociation#auto_import_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoImportPolicy", typeJson: "{\"fqn\":\"aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoImportPolicy\"}", isOptional: true)]
            public aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoImportPolicy? AutoImportPolicy
            {
                get => GetInstanceProperty<aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoImportPolicy?>();
            }
        }
    }
}
