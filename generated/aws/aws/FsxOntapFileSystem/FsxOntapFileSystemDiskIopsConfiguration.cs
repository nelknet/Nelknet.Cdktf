using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapFileSystem
{
    [JsiiByValue(fqn: "aws.fsxOntapFileSystem.FsxOntapFileSystemDiskIopsConfiguration")]
    public class FsxOntapFileSystemDiskIopsConfiguration : aws.FsxOntapFileSystem.IFsxOntapFileSystemDiskIopsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#iops FsxOntapFileSystem#iops}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Iops
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#mode FsxOntapFileSystem#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }
    }
}
