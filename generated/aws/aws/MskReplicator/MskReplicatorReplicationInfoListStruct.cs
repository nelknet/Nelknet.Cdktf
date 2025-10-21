using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskReplicator.MskReplicatorReplicationInfoListStruct")]
    public class MskReplicatorReplicationInfoListStruct : aws.MskReplicator.IMskReplicatorReplicationInfoListStruct
    {
        private object _consumerGroupReplication;

        /// <summary>consumer_group_replication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#consumer_group_replication MskReplicator#consumer_group_replication}
        /// </remarks>
        [JsiiProperty(name: "consumerGroupReplication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListConsumerGroupReplication\"},\"kind\":\"array\"}}]}}")]
        public object ConsumerGroupReplication
        {
            get => _consumerGroupReplication;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MskReplicator.IMskReplicatorReplicationInfoListConsumerGroupReplication[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MskReplicator.IMskReplicatorReplicationInfoListConsumerGroupReplication).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MskReplicator.IMskReplicatorReplicationInfoListConsumerGroupReplication).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _consumerGroupReplication = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#source_kafka_cluster_arn MskReplicator#source_kafka_cluster_arn}.</summary>
        [JsiiProperty(name: "sourceKafkaClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceKafkaClusterArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#target_compression_type MskReplicator#target_compression_type}.</summary>
        [JsiiProperty(name: "targetCompressionType", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetCompressionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#target_kafka_cluster_arn MskReplicator#target_kafka_cluster_arn}.</summary>
        [JsiiProperty(name: "targetKafkaClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetKafkaClusterArn
        {
            get;
            set;
        }

        private object _topicReplication;

        /// <summary>topic_replication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#topic_replication MskReplicator#topic_replication}
        /// </remarks>
        [JsiiProperty(name: "topicReplication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplication\"},\"kind\":\"array\"}}]}}")]
        public object TopicReplication
        {
            get => _topicReplication;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplication[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplication).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplication).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _topicReplication = value;
            }
        }
    }
}
