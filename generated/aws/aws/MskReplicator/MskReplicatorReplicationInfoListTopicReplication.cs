using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplication")]
    public class MskReplicatorReplicationInfoListTopicReplication : aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#topics_to_replicate MskReplicator#topics_to_replicate}.</summary>
        [JsiiProperty(name: "topicsToReplicate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] TopicsToReplicate
        {
            get;
            set;
        }

        private object? _copyAccessControlListsForTopics;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#copy_access_control_lists_for_topics MskReplicator#copy_access_control_lists_for_topics}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copyAccessControlListsForTopics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CopyAccessControlListsForTopics
        {
            get => _copyAccessControlListsForTopics;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _copyAccessControlListsForTopics = value;
            }
        }

        private object? _copyTopicConfigurations;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#copy_topic_configurations MskReplicator#copy_topic_configurations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copyTopicConfigurations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CopyTopicConfigurations
        {
            get => _copyTopicConfigurations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _copyTopicConfigurations = value;
            }
        }

        private object? _detectAndCopyNewTopics;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#detect_and_copy_new_topics MskReplicator#detect_and_copy_new_topics}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "detectAndCopyNewTopics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DetectAndCopyNewTopics
        {
            get => _detectAndCopyNewTopics;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _detectAndCopyNewTopics = value;
            }
        }

        /// <summary>starting_position block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#starting_position MskReplicator#starting_position}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startingPosition", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationStartingPosition\"}", isOptional: true)]
        public aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationStartingPosition? StartingPosition
        {
            get;
            set;
        }

        /// <summary>topic_name_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#topic_name_configuration MskReplicator#topic_name_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "topicNameConfiguration", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationTopicNameConfiguration\"}", isOptional: true)]
        public aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationTopicNameConfiguration? TopicNameConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#topics_to_exclude MskReplicator#topics_to_exclude}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "topicsToExclude", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TopicsToExclude
        {
            get;
            set;
        }
    }
}
