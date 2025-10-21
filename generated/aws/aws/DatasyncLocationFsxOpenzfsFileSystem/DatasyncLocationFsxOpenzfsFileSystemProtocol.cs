using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationFsxOpenzfsFileSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocol")]
    public class DatasyncLocationFsxOpenzfsFileSystemProtocol : aws.DatasyncLocationFsxOpenzfsFileSystem.IDatasyncLocationFsxOpenzfsFileSystemProtocol
    {
        /// <summary>nfs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_openzfs_file_system#nfs DatasyncLocationFsxOpenzfsFileSystem#nfs}
        /// </remarks>
        [JsiiProperty(name: "nfs", typeJson: "{\"fqn\":\"aws.datasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocolNfs\"}")]
        public aws.DatasyncLocationFsxOpenzfsFileSystem.IDatasyncLocationFsxOpenzfsFileSystemProtocolNfs Nfs
        {
            get;
            set;
        }
    }
}
