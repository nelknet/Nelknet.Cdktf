using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    [JsiiClass(nativeType: typeof(aws.IotTopicRule.IotTopicRuleErrorActionKinesisOutputReference), fullyQualifiedName: "aws.iotTopicRule.IotTopicRuleErrorActionKinesisOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotTopicRuleErrorActionKinesisOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotTopicRuleErrorActionKinesisOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IotTopicRuleErrorActionKinesisOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRuleErrorActionKinesisOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPartitionKey")]
        public virtual void ResetPartitionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PartitionKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StreamNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "partitionKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartitionKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionKinesis\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionKinesis? InternalValue
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionKinesis?>();
            set => SetInstanceProperty(value);
        }
    }
}
