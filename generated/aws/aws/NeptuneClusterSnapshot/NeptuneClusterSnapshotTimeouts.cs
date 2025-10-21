using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NeptuneClusterSnapshot
{
    [JsiiByValue(fqn: "aws.neptuneClusterSnapshot.NeptuneClusterSnapshotTimeouts")]
    public class NeptuneClusterSnapshotTimeouts : aws.NeptuneClusterSnapshot.INeptuneClusterSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_snapshot#create NeptuneClusterSnapshot#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
