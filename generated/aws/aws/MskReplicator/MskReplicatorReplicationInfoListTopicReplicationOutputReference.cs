using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiClass(nativeType: typeof(aws.MskReplicator.MskReplicatorReplicationInfoListTopicReplicationOutputReference), fullyQualifiedName: "aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MskReplicatorReplicationInfoListTopicReplicationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MskReplicatorReplicationInfoListTopicReplicationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskReplicatorReplicationInfoListTopicReplicationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskReplicatorReplicationInfoListTopicReplicationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStartingPosition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationStartingPosition\"}}]")]
        public virtual void PutStartingPosition(aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationStartingPosition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationStartingPosition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTopicNameConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationTopicNameConfiguration\"}}]")]
        public virtual void PutTopicNameConfiguration(aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationTopicNameConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationTopicNameConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCopyAccessControlListsForTopics")]
        public virtual void ResetCopyAccessControlListsForTopics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCopyTopicConfigurations")]
        public virtual void ResetCopyTopicConfigurations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDetectAndCopyNewTopics")]
        public virtual void ResetDetectAndCopyNewTopics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartingPosition")]
        public virtual void ResetStartingPosition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTopicNameConfiguration")]
        public virtual void ResetTopicNameConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTopicsToExclude")]
        public virtual void ResetTopicsToExclude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "startingPosition", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationStartingPositionOutputReference\"}")]
        public virtual aws.MskReplicator.MskReplicatorReplicationInfoListTopicReplicationStartingPositionOutputReference StartingPosition
        {
            get => GetInstanceProperty<aws.MskReplicator.MskReplicatorReplicationInfoListTopicReplicationStartingPositionOutputReference>()!;
        }

        [JsiiProperty(name: "topicNameConfiguration", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationTopicNameConfigurationOutputReference\"}")]
        public virtual aws.MskReplicator.MskReplicatorReplicationInfoListTopicReplicationTopicNameConfigurationOutputReference TopicNameConfiguration
        {
            get => GetInstanceProperty<aws.MskReplicator.MskReplicatorReplicationInfoListTopicReplicationTopicNameConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyAccessControlListsForTopicsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CopyAccessControlListsForTopicsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyTopicConfigurationsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CopyTopicConfigurationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "detectAndCopyNewTopicsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DetectAndCopyNewTopicsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startingPositionInput", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationStartingPosition\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationStartingPosition? StartingPositionInput
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationStartingPosition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicNameConfigurationInput", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationTopicNameConfiguration\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationTopicNameConfiguration? TopicNameConfigurationInput
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationTopicNameConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicsToExcludeInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TopicsToExcludeInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicsToReplicateInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TopicsToReplicateInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "copyAccessControlListsForTopics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CopyAccessControlListsForTopics
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "copyTopicConfigurations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CopyTopicConfigurations
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "detectAndCopyNewTopics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DetectAndCopyNewTopics
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "topicsToExclude", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TopicsToExclude
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "topicsToReplicate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TopicsToReplicate
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplication\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplication cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplication).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
