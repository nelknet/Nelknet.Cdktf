using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiClass(nativeType: typeof(aws.MskReplicator.MskReplicatorReplicationInfoListStructOutputReference), fullyQualifiedName: "aws.mskReplicator.MskReplicatorReplicationInfoListStructOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskReplicatorReplicationInfoListStructOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskReplicatorReplicationInfoListStructOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskReplicatorReplicationInfoListStructOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskReplicatorReplicationInfoListStructOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConsumerGroupReplication", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListConsumerGroupReplication\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConsumerGroupReplication(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.MskReplicator.IMskReplicatorReplicationInfoListConsumerGroupReplication[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MskReplicator.IMskReplicatorReplicationInfoListConsumerGroupReplication).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MskReplicator.IMskReplicatorReplicationInfoListConsumerGroupReplication).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTopicReplication", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplication\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTopicReplication(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplication[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplication).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplication).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "consumerGroupReplication", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListConsumerGroupReplicationList\"}")]
        public virtual aws.MskReplicator.MskReplicatorReplicationInfoListConsumerGroupReplicationList ConsumerGroupReplication
        {
            get => GetInstanceProperty<aws.MskReplicator.MskReplicatorReplicationInfoListConsumerGroupReplicationList>()!;
        }

        [JsiiProperty(name: "sourceKafkaClusterAlias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceKafkaClusterAlias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetKafkaClusterAlias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetKafkaClusterAlias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "topicReplication", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationList\"}")]
        public virtual aws.MskReplicator.MskReplicatorReplicationInfoListTopicReplicationList TopicReplication
        {
            get => GetInstanceProperty<aws.MskReplicator.MskReplicatorReplicationInfoListTopicReplicationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "consumerGroupReplicationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListConsumerGroupReplication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConsumerGroupReplicationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceKafkaClusterArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceKafkaClusterArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetCompressionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetCompressionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetKafkaClusterArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetKafkaClusterArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicReplicationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TopicReplicationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "sourceKafkaClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceKafkaClusterArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetCompressionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetCompressionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetKafkaClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetKafkaClusterArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListStruct\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorReplicationInfoListStruct? InternalValue
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorReplicationInfoListStruct?>();
            set => SetInstanceProperty(value);
        }
    }
}
