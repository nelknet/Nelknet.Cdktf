using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskReplicator.MskReplicatorKafkaCluster")]
    public class MskReplicatorKafkaCluster : aws.MskReplicator.IMskReplicatorKafkaCluster
    {
        /// <summary>amazon_msk_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#amazon_msk_cluster MskReplicator#amazon_msk_cluster}
        /// </remarks>
        [JsiiProperty(name: "amazonMskCluster", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterAmazonMskCluster\"}")]
        public aws.MskReplicator.IMskReplicatorKafkaClusterAmazonMskCluster AmazonMskCluster
        {
            get;
            set;
        }

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#vpc_config MskReplicator#vpc_config}
        /// </remarks>
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterVpcConfig\"}")]
        public aws.MskReplicator.IMskReplicatorKafkaClusterVpcConfig VpcConfig
        {
            get;
            set;
        }
    }
}
