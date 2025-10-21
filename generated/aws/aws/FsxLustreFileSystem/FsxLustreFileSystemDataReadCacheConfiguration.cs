using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxLustreFileSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsxLustreFileSystem.FsxLustreFileSystemDataReadCacheConfiguration")]
    public class FsxLustreFileSystemDataReadCacheConfiguration : aws.FsxLustreFileSystem.IFsxLustreFileSystemDataReadCacheConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#sizing_mode FsxLustreFileSystem#sizing_mode}.</summary>
        [JsiiProperty(name: "sizingMode", typeJson: "{\"primitive\":\"string\"}")]
        public string SizingMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#size FsxLustreFileSystem#size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Size
        {
            get;
            set;
        }
    }
}
