using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationFsxOntapFileSystem
{
    [JsiiByValue(fqn: "aws.datasyncLocationFsxOntapFileSystem.DatasyncLocationFsxOntapFileSystemProtocol")]
    public class DatasyncLocationFsxOntapFileSystemProtocol : aws.DatasyncLocationFsxOntapFileSystem.IDatasyncLocationFsxOntapFileSystemProtocol
    {
        /// <summary>nfs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_ontap_file_system#nfs DatasyncLocationFsxOntapFileSystem#nfs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nfs", typeJson: "{\"fqn\":\"aws.datasyncLocationFsxOntapFileSystem.DatasyncLocationFsxOntapFileSystemProtocolNfs\"}", isOptional: true)]
        public aws.DatasyncLocationFsxOntapFileSystem.IDatasyncLocationFsxOntapFileSystemProtocolNfs? Nfs
        {
            get;
            set;
        }

        /// <summary>smb block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_ontap_file_system#smb DatasyncLocationFsxOntapFileSystem#smb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smb", typeJson: "{\"fqn\":\"aws.datasyncLocationFsxOntapFileSystem.DatasyncLocationFsxOntapFileSystemProtocolSmb\"}", isOptional: true)]
        public aws.DatasyncLocationFsxOntapFileSystem.IDatasyncLocationFsxOntapFileSystemProtocolSmb? Smb
        {
            get;
            set;
        }
    }
}
