using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxDataRepositoryAssociation
{
    [JsiiByValue(fqn: "aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3")]
    public class FsxDataRepositoryAssociationS3 : aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3
    {
        /// <summary>auto_export_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#auto_export_policy FsxDataRepositoryAssociation#auto_export_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoExportPolicy", typeJson: "{\"fqn\":\"aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoExportPolicy\"}", isOptional: true)]
        public aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoExportPolicy? AutoExportPolicy
        {
            get;
            set;
        }

        /// <summary>auto_import_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#auto_import_policy FsxDataRepositoryAssociation#auto_import_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoImportPolicy", typeJson: "{\"fqn\":\"aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoImportPolicy\"}", isOptional: true)]
        public aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoImportPolicy? AutoImportPolicy
        {
            get;
            set;
        }
    }
}
