using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOpenzfsFileSystem
{
    [JsiiInterface(nativeType: typeof(IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations), fullyQualifiedName: "aws.fsxOpenzfsFileSystem.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations")]
    public interface IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#clients FsxOpenzfsFileSystem#clients}.</summary>
        [JsiiProperty(name: "clients", typeJson: "{\"primitive\":\"string\"}")]
        string Clients
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#options FsxOpenzfsFileSystem#options}.</summary>
        [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Options
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations), fullyQualifiedName: "aws.fsxOpenzfsFileSystem.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations")]
        internal sealed class _Proxy : DeputyBase, aws.FsxOpenzfsFileSystem.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#clients FsxOpenzfsFileSystem#clients}.</summary>
            [JsiiProperty(name: "clients", typeJson: "{\"primitive\":\"string\"}")]
            public string Clients
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#options FsxOpenzfsFileSystem#options}.</summary>
            [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Options
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
