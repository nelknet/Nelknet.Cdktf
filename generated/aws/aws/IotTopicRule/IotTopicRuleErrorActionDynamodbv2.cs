using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iotTopicRule.IotTopicRuleErrorActionDynamodbv2")]
    public class IotTopicRuleErrorActionDynamodbv2 : aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>put_item block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#put_item IotTopicRule#put_item}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "putItem", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodbv2PutItem\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2PutItem? PutItem
        {
            get;
            set;
        }
    }
}
