using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiInterface(nativeType: typeof(IMskReplicatorReplicationInfoListStruct), fullyQualifiedName: "aws.mskReplicator.MskReplicatorReplicationInfoListStruct")]
    public interface IMskReplicatorReplicationInfoListStruct
    {
        /// <summary>consumer_group_replication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#consumer_group_replication MskReplicator#consumer_group_replication}
        /// </remarks>
        [JsiiProperty(name: "consumerGroupReplication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListConsumerGroupReplication\"},\"kind\":\"array\"}}]}}")]
        object ConsumerGroupReplication
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#source_kafka_cluster_arn MskReplicator#source_kafka_cluster_arn}.</summary>
        [JsiiProperty(name: "sourceKafkaClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        string SourceKafkaClusterArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#target_compression_type MskReplicator#target_compression_type}.</summary>
        [JsiiProperty(name: "targetCompressionType", typeJson: "{\"primitive\":\"string\"}")]
        string TargetCompressionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#target_kafka_cluster_arn MskReplicator#target_kafka_cluster_arn}.</summary>
        [JsiiProperty(name: "targetKafkaClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        string TargetKafkaClusterArn
        {
            get;
        }

        /// <summary>topic_replication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#topic_replication MskReplicator#topic_replication}
        /// </remarks>
        [JsiiProperty(name: "topicReplication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplication\"},\"kind\":\"array\"}}]}}")]
        object TopicReplication
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskReplicatorReplicationInfoListStruct), fullyQualifiedName: "aws.mskReplicator.MskReplicatorReplicationInfoListStruct")]
        internal sealed class _Proxy : DeputyBase, aws.MskReplicator.IMskReplicatorReplicationInfoListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>consumer_group_replication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#consumer_group_replication MskReplicator#consumer_group_replication}
            /// </remarks>
            [JsiiProperty(name: "consumerGroupReplication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListConsumerGroupReplication\"},\"kind\":\"array\"}}]}}")]
            public object ConsumerGroupReplication
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#source_kafka_cluster_arn MskReplicator#source_kafka_cluster_arn}.</summary>
            [JsiiProperty(name: "sourceKafkaClusterArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceKafkaClusterArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#target_compression_type MskReplicator#target_compression_type}.</summary>
            [JsiiProperty(name: "targetCompressionType", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetCompressionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#target_kafka_cluster_arn MskReplicator#target_kafka_cluster_arn}.</summary>
            [JsiiProperty(name: "targetKafkaClusterArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetKafkaClusterArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>topic_replication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#topic_replication MskReplicator#topic_replication}
            /// </remarks>
            [JsiiProperty(name: "topicReplication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplication\"},\"kind\":\"array\"}}]}}")]
            public object TopicReplication
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
