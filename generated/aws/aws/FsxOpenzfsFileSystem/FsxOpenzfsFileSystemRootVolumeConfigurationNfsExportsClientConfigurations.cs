using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOpenzfsFileSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsxOpenzfsFileSystem.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations")]
    public class FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations : aws.FsxOpenzfsFileSystem.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#clients FsxOpenzfsFileSystem#clients}.</summary>
        [JsiiProperty(name: "clients", typeJson: "{\"primitive\":\"string\"}")]
        public string Clients
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#options FsxOpenzfsFileSystem#options}.</summary>
        [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Options
        {
            get;
            set;
        }
    }
}
