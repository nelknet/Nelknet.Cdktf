using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationFsxOpenzfsFileSystem
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationFsxOpenzfsFileSystemProtocolNfs), fullyQualifiedName: "aws.datasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocolNfs")]
    public interface IDatasyncLocationFsxOpenzfsFileSystemProtocolNfs
    {
        /// <summary>mount_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_openzfs_file_system#mount_options DatasyncLocationFsxOpenzfsFileSystem#mount_options}
        /// </remarks>
        [JsiiProperty(name: "mountOptions", typeJson: "{\"fqn\":\"aws.datasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptions\"}")]
        aws.DatasyncLocationFsxOpenzfsFileSystem.IDatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptions MountOptions
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationFsxOpenzfsFileSystemProtocolNfs), fullyQualifiedName: "aws.datasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocolNfs")]
        internal sealed class _Proxy : DeputyBase, aws.DatasyncLocationFsxOpenzfsFileSystem.IDatasyncLocationFsxOpenzfsFileSystemProtocolNfs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>mount_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_openzfs_file_system#mount_options DatasyncLocationFsxOpenzfsFileSystem#mount_options}
            /// </remarks>
            [JsiiProperty(name: "mountOptions", typeJson: "{\"fqn\":\"aws.datasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptions\"}")]
            public aws.DatasyncLocationFsxOpenzfsFileSystem.IDatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptions MountOptions
            {
                get => GetInstanceProperty<aws.DatasyncLocationFsxOpenzfsFileSystem.IDatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptions>()!;
            }
        }
    }
}
