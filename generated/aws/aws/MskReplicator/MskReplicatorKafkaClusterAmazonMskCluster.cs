using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskReplicator.MskReplicatorKafkaClusterAmazonMskCluster")]
    public class MskReplicatorKafkaClusterAmazonMskCluster : aws.MskReplicator.IMskReplicatorKafkaClusterAmazonMskCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#msk_cluster_arn MskReplicator#msk_cluster_arn}.</summary>
        [JsiiProperty(name: "mskClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public string MskClusterArn
        {
            get;
            set;
        }
    }
}
