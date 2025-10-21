using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    [JsiiClass(nativeType: typeof(aws.IotTopicRule.IotTopicRuleErrorActionDynamodbv2OutputReference), fullyQualifiedName: "aws.iotTopicRule.IotTopicRuleErrorActionDynamodbv2OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotTopicRuleErrorActionDynamodbv2OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotTopicRuleErrorActionDynamodbv2OutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IotTopicRuleErrorActionDynamodbv2OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRuleErrorActionDynamodbv2OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPutItem", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodbv2PutItem\"}}]")]
        public virtual void PutPutItem(aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2PutItem @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2PutItem)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPutItem")]
        public virtual void ResetPutItem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "putItem", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodbv2PutItemOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionDynamodbv2PutItemOutputReference PutItem
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionDynamodbv2PutItemOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "putItemInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodbv2PutItem\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2PutItem? PutItemInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2PutItem?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodbv2\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2? InternalValue
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2?>();
            set => SetInstanceProperty(value);
        }
    }
}
