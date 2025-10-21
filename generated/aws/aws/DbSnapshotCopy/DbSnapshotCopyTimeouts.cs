using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbSnapshotCopy
{
    [JsiiByValue(fqn: "aws.dbSnapshotCopy.DbSnapshotCopyTimeouts")]
    public class DbSnapshotCopyTimeouts : aws.DbSnapshotCopy.IDbSnapshotCopyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#create DbSnapshotCopy#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
