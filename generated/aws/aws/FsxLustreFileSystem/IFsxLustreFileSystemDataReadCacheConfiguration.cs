using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxLustreFileSystem
{
    [JsiiInterface(nativeType: typeof(IFsxLustreFileSystemDataReadCacheConfiguration), fullyQualifiedName: "aws.fsxLustreFileSystem.FsxLustreFileSystemDataReadCacheConfiguration")]
    public interface IFsxLustreFileSystemDataReadCacheConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#sizing_mode FsxLustreFileSystem#sizing_mode}.</summary>
        [JsiiProperty(name: "sizingMode", typeJson: "{\"primitive\":\"string\"}")]
        string SizingMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#size FsxLustreFileSystem#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Size
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxLustreFileSystemDataReadCacheConfiguration), fullyQualifiedName: "aws.fsxLustreFileSystem.FsxLustreFileSystemDataReadCacheConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FsxLustreFileSystem.IFsxLustreFileSystemDataReadCacheConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#sizing_mode FsxLustreFileSystem#sizing_mode}.</summary>
            [JsiiProperty(name: "sizingMode", typeJson: "{\"primitive\":\"string\"}")]
            public string SizingMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#size FsxLustreFileSystem#size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Size
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
