using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iotTopicRule.IotTopicRuleRepublish")]
    public class IotTopicRuleRepublish : aws.IotTopicRule.IIotTopicRuleRepublish
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#topic IotTopicRule#topic}.</summary>
        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}")]
        public string Topic
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#qos IotTopicRule#qos}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "qos", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Qos
        {
            get;
            set;
        }
    }
}
