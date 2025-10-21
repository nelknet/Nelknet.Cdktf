using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationFsxOpenzfsFileSystem
{
    [JsiiByValue(fqn: "aws.datasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptions")]
    public class DatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptions : aws.DatasyncLocationFsxOpenzfsFileSystem.IDatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_openzfs_file_system#version DatasyncLocationFsxOpenzfsFileSystem#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
