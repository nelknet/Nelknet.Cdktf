using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiInterface(nativeType: typeof(IMskReplicatorKafkaCluster), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaCluster")]
    public interface IMskReplicatorKafkaCluster
    {
        /// <summary>amazon_msk_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#amazon_msk_cluster MskReplicator#amazon_msk_cluster}
        /// </remarks>
        [JsiiProperty(name: "amazonMskCluster", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterAmazonMskCluster\"}")]
        aws.MskReplicator.IMskReplicatorKafkaClusterAmazonMskCluster AmazonMskCluster
        {
            get;
        }

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#vpc_config MskReplicator#vpc_config}
        /// </remarks>
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterVpcConfig\"}")]
        aws.MskReplicator.IMskReplicatorKafkaClusterVpcConfig VpcConfig
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskReplicatorKafkaCluster), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaCluster")]
        internal sealed class _Proxy : DeputyBase, aws.MskReplicator.IMskReplicatorKafkaCluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>amazon_msk_cluster block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#amazon_msk_cluster MskReplicator#amazon_msk_cluster}
            /// </remarks>
            [JsiiProperty(name: "amazonMskCluster", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterAmazonMskCluster\"}")]
            public aws.MskReplicator.IMskReplicatorKafkaClusterAmazonMskCluster AmazonMskCluster
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterAmazonMskCluster>()!;
            }

            /// <summary>vpc_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#vpc_config MskReplicator#vpc_config}
            /// </remarks>
            [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterVpcConfig\"}")]
            public aws.MskReplicator.IMskReplicatorKafkaClusterVpcConfig VpcConfig
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterVpcConfig>()!;
            }
        }
    }
}
