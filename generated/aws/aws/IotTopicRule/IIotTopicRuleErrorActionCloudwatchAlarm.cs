using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionCloudwatchAlarm), fullyQualifiedName: "aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchAlarm")]
    public interface IIotTopicRuleErrorActionCloudwatchAlarm
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#alarm_name IotTopicRule#alarm_name}.</summary>
        [JsiiProperty(name: "alarmName", typeJson: "{\"primitive\":\"string\"}")]
        string AlarmName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#state_reason IotTopicRule#state_reason}.</summary>
        [JsiiProperty(name: "stateReason", typeJson: "{\"primitive\":\"string\"}")]
        string StateReason
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#state_value IotTopicRule#state_value}.</summary>
        [JsiiProperty(name: "stateValue", typeJson: "{\"primitive\":\"string\"}")]
        string StateValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionCloudwatchAlarm), fullyQualifiedName: "aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchAlarm")]
        internal sealed class _Proxy : DeputyBase, aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchAlarm
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#alarm_name IotTopicRule#alarm_name}.</summary>
            [JsiiProperty(name: "alarmName", typeJson: "{\"primitive\":\"string\"}")]
            public string AlarmName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#state_reason IotTopicRule#state_reason}.</summary>
            [JsiiProperty(name: "stateReason", typeJson: "{\"primitive\":\"string\"}")]
            public string StateReason
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#state_value IotTopicRule#state_value}.</summary>
            [JsiiProperty(name: "stateValue", typeJson: "{\"primitive\":\"string\"}")]
            public string StateValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
