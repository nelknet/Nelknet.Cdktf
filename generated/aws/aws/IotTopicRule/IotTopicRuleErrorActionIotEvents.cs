using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iotTopicRule.IotTopicRuleErrorActionIotEvents")]
    public class IotTopicRuleErrorActionIotEvents : aws.IotTopicRule.IIotTopicRuleErrorActionIotEvents
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#input_name IotTopicRule#input_name}.</summary>
        [JsiiProperty(name: "inputName", typeJson: "{\"primitive\":\"string\"}")]
        public string InputName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        private object? _batchMode;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#batch_mode IotTopicRule#batch_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? BatchMode
        {
            get => _batchMode;
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
                _batchMode = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#message_id IotTopicRule#message_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageId
        {
            get;
            set;
        }
    }
}
