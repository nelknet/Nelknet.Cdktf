using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EfsFileSystem
{
    [JsiiByValue(fqn: "aws.efsFileSystem.EfsFileSystemProtection")]
    public class EfsFileSystemProtection : aws.EfsFileSystem.IEfsFileSystemProtection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#replication_overwrite EfsFileSystem#replication_overwrite}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicationOverwrite", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplicationOverwrite
        {
            get;
            set;
        }
    }
}
