using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionCloudwatchMetric), fullyQualifiedName: "aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchMetric")]
    public interface IIotTopicRuleErrorActionCloudwatchMetric
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#metric_name IotTopicRule#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        string MetricName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#metric_namespace IotTopicRule#metric_namespace}.</summary>
        [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}")]
        string MetricNamespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#metric_unit IotTopicRule#metric_unit}.</summary>
        [JsiiProperty(name: "metricUnit", typeJson: "{\"primitive\":\"string\"}")]
        string MetricUnit
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#metric_value IotTopicRule#metric_value}.</summary>
        [JsiiProperty(name: "metricValue", typeJson: "{\"primitive\":\"string\"}")]
        string MetricValue
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#metric_timestamp IotTopicRule#metric_timestamp}.</summary>
        [JsiiProperty(name: "metricTimestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricTimestamp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionCloudwatchMetric), fullyQualifiedName: "aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchMetric")]
        internal sealed class _Proxy : DeputyBase, aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchMetric
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#metric_name IotTopicRule#metric_name}.</summary>
            [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#metric_namespace IotTopicRule#metric_namespace}.</summary>
            [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricNamespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#metric_unit IotTopicRule#metric_unit}.</summary>
            [JsiiProperty(name: "metricUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricUnit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#metric_value IotTopicRule#metric_value}.</summary>
            [JsiiProperty(name: "metricValue", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#metric_timestamp IotTopicRule#metric_timestamp}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricTimestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricTimestamp
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
