using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EfsFileSystem
{
    [JsiiInterface(nativeType: typeof(IEfsFileSystemProtection), fullyQualifiedName: "aws.efsFileSystem.EfsFileSystemProtection")]
    public interface IEfsFileSystemProtection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#replication_overwrite EfsFileSystem#replication_overwrite}.</summary>
        [JsiiProperty(name: "replicationOverwrite", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplicationOverwrite
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsFileSystemProtection), fullyQualifiedName: "aws.efsFileSystem.EfsFileSystemProtection")]
        internal sealed class _Proxy : DeputyBase, aws.EfsFileSystem.IEfsFileSystemProtection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#replication_overwrite EfsFileSystem#replication_overwrite}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicationOverwrite", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplicationOverwrite
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
