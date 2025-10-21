using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxLustreFileSystem
{
    [JsiiByValue(fqn: "aws.fsxLustreFileSystem.FsxLustreFileSystemRootSquashConfiguration")]
    public class FsxLustreFileSystemRootSquashConfiguration : aws.FsxLustreFileSystem.IFsxLustreFileSystemRootSquashConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#no_squash_nids FsxLustreFileSystem#no_squash_nids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "noSquashNids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NoSquashNids
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#root_squash FsxLustreFileSystem#root_squash}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootSquash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RootSquash
        {
            get;
            set;
        }
    }
}
