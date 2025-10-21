using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DocdbClusterSnapshot
{
    [JsiiByValue(fqn: "aws.docdbClusterSnapshot.DocdbClusterSnapshotTimeouts")]
    public class DocdbClusterSnapshotTimeouts : aws.DocdbClusterSnapshot.IDocdbClusterSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_snapshot#create DocdbClusterSnapshot#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
