using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionDynamodb), fullyQualifiedName: "aws.iotTopicRule.IotTopicRuleErrorActionDynamodb")]
    public interface IIotTopicRuleErrorActionDynamodb
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#hash_key_field IotTopicRule#hash_key_field}.</summary>
        [JsiiProperty(name: "hashKeyField", typeJson: "{\"primitive\":\"string\"}")]
        string HashKeyField
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#hash_key_value IotTopicRule#hash_key_value}.</summary>
        [JsiiProperty(name: "hashKeyValue", typeJson: "{\"primitive\":\"string\"}")]
        string HashKeyValue
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#table_name IotTopicRule#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        string TableName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#hash_key_type IotTopicRule#hash_key_type}.</summary>
        [JsiiProperty(name: "hashKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HashKeyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#operation IotTopicRule#operation}.</summary>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Operation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#payload_field IotTopicRule#payload_field}.</summary>
        [JsiiProperty(name: "payloadField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PayloadField
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#range_key_field IotTopicRule#range_key_field}.</summary>
        [JsiiProperty(name: "rangeKeyField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RangeKeyField
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#range_key_type IotTopicRule#range_key_type}.</summary>
        [JsiiProperty(name: "rangeKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RangeKeyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#range_key_value IotTopicRule#range_key_value}.</summary>
        [JsiiProperty(name: "rangeKeyValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RangeKeyValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionDynamodb), fullyQualifiedName: "aws.iotTopicRule.IotTopicRuleErrorActionDynamodb")]
        internal sealed class _Proxy : DeputyBase, aws.IotTopicRule.IIotTopicRuleErrorActionDynamodb
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#hash_key_field IotTopicRule#hash_key_field}.</summary>
            [JsiiProperty(name: "hashKeyField", typeJson: "{\"primitive\":\"string\"}")]
            public string HashKeyField
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#hash_key_value IotTopicRule#hash_key_value}.</summary>
            [JsiiProperty(name: "hashKeyValue", typeJson: "{\"primitive\":\"string\"}")]
            public string HashKeyValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#table_name IotTopicRule#table_name}.</summary>
            [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
            public string TableName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#hash_key_type IotTopicRule#hash_key_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hashKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HashKeyType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#operation IotTopicRule#operation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Operation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#payload_field IotTopicRule#payload_field}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "payloadField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PayloadField
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#range_key_field IotTopicRule#range_key_field}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rangeKeyField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RangeKeyField
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#range_key_type IotTopicRule#range_key_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rangeKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RangeKeyType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#range_key_value IotTopicRule#range_key_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rangeKeyValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RangeKeyValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
