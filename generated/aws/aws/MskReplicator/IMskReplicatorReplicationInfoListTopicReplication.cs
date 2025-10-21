using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiInterface(nativeType: typeof(IMskReplicatorReplicationInfoListTopicReplication), fullyQualifiedName: "aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplication")]
    public interface IMskReplicatorReplicationInfoListTopicReplication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#topics_to_replicate MskReplicator#topics_to_replicate}.</summary>
        [JsiiProperty(name: "topicsToReplicate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] TopicsToReplicate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#copy_access_control_lists_for_topics MskReplicator#copy_access_control_lists_for_topics}.</summary>
        [JsiiProperty(name: "copyAccessControlListsForTopics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CopyAccessControlListsForTopics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#copy_topic_configurations MskReplicator#copy_topic_configurations}.</summary>
        [JsiiProperty(name: "copyTopicConfigurations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CopyTopicConfigurations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#detect_and_copy_new_topics MskReplicator#detect_and_copy_new_topics}.</summary>
        [JsiiProperty(name: "detectAndCopyNewTopics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DetectAndCopyNewTopics
        {
            get
            {
                return null;
            }
        }

        /// <summary>starting_position block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#starting_position MskReplicator#starting_position}
        /// </remarks>
        [JsiiProperty(name: "startingPosition", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationStartingPosition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationStartingPosition? StartingPosition
        {
            get
            {
                return null;
            }
        }

        /// <summary>topic_name_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#topic_name_configuration MskReplicator#topic_name_configuration}
        /// </remarks>
        [JsiiProperty(name: "topicNameConfiguration", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationTopicNameConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationTopicNameConfiguration? TopicNameConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#topics_to_exclude MskReplicator#topics_to_exclude}.</summary>
        [JsiiProperty(name: "topicsToExclude", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TopicsToExclude
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskReplicatorReplicationInfoListTopicReplication), fullyQualifiedName: "aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplication")]
        internal sealed class _Proxy : DeputyBase, aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#topics_to_replicate MskReplicator#topics_to_replicate}.</summary>
            [JsiiProperty(name: "topicsToReplicate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] TopicsToReplicate
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#copy_access_control_lists_for_topics MskReplicator#copy_access_control_lists_for_topics}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "copyAccessControlListsForTopics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CopyAccessControlListsForTopics
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#copy_topic_configurations MskReplicator#copy_topic_configurations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "copyTopicConfigurations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CopyTopicConfigurations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#detect_and_copy_new_topics MskReplicator#detect_and_copy_new_topics}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "detectAndCopyNewTopics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DetectAndCopyNewTopics
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>starting_position block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#starting_position MskReplicator#starting_position}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startingPosition", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationStartingPosition\"}", isOptional: true)]
            public aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationStartingPosition? StartingPosition
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationStartingPosition?>();
            }

            /// <summary>topic_name_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#topic_name_configuration MskReplicator#topic_name_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "topicNameConfiguration", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationTopicNameConfiguration\"}", isOptional: true)]
            public aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationTopicNameConfiguration? TopicNameConfiguration
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationTopicNameConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#topics_to_exclude MskReplicator#topics_to_exclude}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "topicsToExclude", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TopicsToExclude
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
