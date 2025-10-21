using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiInterface(nativeType: typeof(IMskReplicatorKafkaClusterAmazonMskCluster), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterAmazonMskCluster")]
    public interface IMskReplicatorKafkaClusterAmazonMskCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#msk_cluster_arn MskReplicator#msk_cluster_arn}.</summary>
        [JsiiProperty(name: "mskClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        string MskClusterArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskReplicatorKafkaClusterAmazonMskCluster), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterAmazonMskCluster")]
        internal sealed class _Proxy : DeputyBase, aws.MskReplicator.IMskReplicatorKafkaClusterAmazonMskCluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#msk_cluster_arn MskReplicator#msk_cluster_arn}.</summary>
            [JsiiProperty(name: "mskClusterArn", typeJson: "{\"primitive\":\"string\"}")]
            public string MskClusterArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
