using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleStepFunctions), fullyQualifiedName: "aws.iotTopicRule.IotTopicRuleStepFunctions")]
    public interface IIotTopicRuleStepFunctions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#state_machine_name IotTopicRule#state_machine_name}.</summary>
        [JsiiProperty(name: "stateMachineName", typeJson: "{\"primitive\":\"string\"}")]
        string StateMachineName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#execution_name_prefix IotTopicRule#execution_name_prefix}.</summary>
        [JsiiProperty(name: "executionNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExecutionNamePrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleStepFunctions), fullyQualifiedName: "aws.iotTopicRule.IotTopicRuleStepFunctions")]
        internal sealed class _Proxy : DeputyBase, aws.IotTopicRule.IIotTopicRuleStepFunctions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#state_machine_name IotTopicRule#state_machine_name}.</summary>
            [JsiiProperty(name: "stateMachineName", typeJson: "{\"primitive\":\"string\"}")]
            public string StateMachineName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#execution_name_prefix IotTopicRule#execution_name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executionNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExecutionNamePrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
