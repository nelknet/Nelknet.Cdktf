using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationFsxOntapFileSystem
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationFsxOntapFileSystemProtocolNfs), fullyQualifiedName: "aws.datasyncLocationFsxOntapFileSystem.DatasyncLocationFsxOntapFileSystemProtocolNfs")]
    public interface IDatasyncLocationFsxOntapFileSystemProtocolNfs
    {
        /// <summary>mount_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_ontap_file_system#mount_options DatasyncLocationFsxOntapFileSystem#mount_options}
        /// </remarks>
        [JsiiProperty(name: "mountOptions", typeJson: "{\"fqn\":\"aws.datasyncLocationFsxOntapFileSystem.DatasyncLocationFsxOntapFileSystemProtocolNfsMountOptions\"}")]
        aws.DatasyncLocationFsxOntapFileSystem.IDatasyncLocationFsxOntapFileSystemProtocolNfsMountOptions MountOptions
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationFsxOntapFileSystemProtocolNfs), fullyQualifiedName: "aws.datasyncLocationFsxOntapFileSystem.DatasyncLocationFsxOntapFileSystemProtocolNfs")]
        internal sealed class _Proxy : DeputyBase, aws.DatasyncLocationFsxOntapFileSystem.IDatasyncLocationFsxOntapFileSystemProtocolNfs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>mount_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_ontap_file_system#mount_options DatasyncLocationFsxOntapFileSystem#mount_options}
            /// </remarks>
            [JsiiProperty(name: "mountOptions", typeJson: "{\"fqn\":\"aws.datasyncLocationFsxOntapFileSystem.DatasyncLocationFsxOntapFileSystemProtocolNfsMountOptions\"}")]
            public aws.DatasyncLocationFsxOntapFileSystem.IDatasyncLocationFsxOntapFileSystemProtocolNfsMountOptions MountOptions
            {
                get => GetInstanceProperty<aws.DatasyncLocationFsxOntapFileSystem.IDatasyncLocationFsxOntapFileSystemProtocolNfsMountOptions>()!;
            }
        }
    }
}
