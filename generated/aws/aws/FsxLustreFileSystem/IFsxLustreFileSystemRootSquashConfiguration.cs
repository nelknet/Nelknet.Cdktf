using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxLustreFileSystem
{
    [JsiiInterface(nativeType: typeof(IFsxLustreFileSystemRootSquashConfiguration), fullyQualifiedName: "aws.fsxLustreFileSystem.FsxLustreFileSystemRootSquashConfiguration")]
    public interface IFsxLustreFileSystemRootSquashConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#no_squash_nids FsxLustreFileSystem#no_squash_nids}.</summary>
        [JsiiProperty(name: "noSquashNids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NoSquashNids
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#root_squash FsxLustreFileSystem#root_squash}.</summary>
        [JsiiProperty(name: "rootSquash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RootSquash
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxLustreFileSystemRootSquashConfiguration), fullyQualifiedName: "aws.fsxLustreFileSystem.FsxLustreFileSystemRootSquashConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FsxLustreFileSystem.IFsxLustreFileSystemRootSquashConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#no_squash_nids FsxLustreFileSystem#no_squash_nids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "noSquashNids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NoSquashNids
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#root_squash FsxLustreFileSystem#root_squash}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rootSquash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RootSquash
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
