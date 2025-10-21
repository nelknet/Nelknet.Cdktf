using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iotTopicRule.IotTopicRuleDynamodb")]
    public class IotTopicRuleDynamodb : aws.IotTopicRule.IIotTopicRuleDynamodb
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#hash_key_field IotTopicRule#hash_key_field}.</summary>
        [JsiiProperty(name: "hashKeyField", typeJson: "{\"primitive\":\"string\"}")]
        public string HashKeyField
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#hash_key_value IotTopicRule#hash_key_value}.</summary>
        [JsiiProperty(name: "hashKeyValue", typeJson: "{\"primitive\":\"string\"}")]
        public string HashKeyValue
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#table_name IotTopicRule#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public string TableName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#hash_key_type IotTopicRule#hash_key_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hashKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HashKeyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#operation IotTopicRule#operation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Operation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#payload_field IotTopicRule#payload_field}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "payloadField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PayloadField
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#range_key_field IotTopicRule#range_key_field}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rangeKeyField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RangeKeyField
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#range_key_type IotTopicRule#range_key_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rangeKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RangeKeyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#range_key_value IotTopicRule#range_key_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rangeKeyValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RangeKeyValue
        {
            get;
            set;
        }
    }
}
