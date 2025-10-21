using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbClusterSnapshot
{
    [JsiiByValue(fqn: "aws.dbClusterSnapshot.DbClusterSnapshotTimeouts")]
    public class DbClusterSnapshotTimeouts : aws.DbClusterSnapshot.IDbClusterSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_cluster_snapshot#create DbClusterSnapshot#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
