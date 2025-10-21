using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    [JsiiByValue(fqn: "aws.iotTopicRule.IotTopicRuleErrorAction")]
    public class IotTopicRuleErrorAction : aws.IotTopicRule.IIotTopicRuleErrorAction
    {
        /// <summary>cloudwatch_alarm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#cloudwatch_alarm IotTopicRule#cloudwatch_alarm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchAlarm\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchAlarm? CloudwatchAlarm
        {
            get;
            set;
        }

        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#cloudwatch_logs IotTopicRule#cloudwatch_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchLogs\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchLogs? CloudwatchLogs
        {
            get;
            set;
        }

        /// <summary>cloudwatch_metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#cloudwatch_metric IotTopicRule#cloudwatch_metric}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchMetric\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchMetric? CloudwatchMetric
        {
            get;
            set;
        }

        /// <summary>dynamodb block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#dynamodb IotTopicRule#dynamodb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dynamodb", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodb\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionDynamodb? Dynamodb
        {
            get;
            set;
        }

        /// <summary>dynamodbv2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#dynamodbv2 IotTopicRule#dynamodbv2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dynamodbv2", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodbv2\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2? Dynamodbv2
        {
            get;
            set;
        }

        /// <summary>elasticsearch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#elasticsearch IotTopicRule#elasticsearch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "elasticsearch", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionElasticsearch\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionElasticsearch? Elasticsearch
        {
            get;
            set;
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#firehose IotTopicRule#firehose}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionFirehose\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionFirehose? Firehose
        {
            get;
            set;
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#http IotTopicRule#http}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionHttp\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionHttp? Http
        {
            get;
            set;
        }

        /// <summary>iot_analytics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#iot_analytics IotTopicRule#iot_analytics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iotAnalytics", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionIotAnalytics\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionIotAnalytics? IotAnalytics
        {
            get;
            set;
        }

        /// <summary>iot_events block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#iot_events IotTopicRule#iot_events}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iotEvents", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionIotEvents\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionIotEvents? IotEvents
        {
            get;
            set;
        }

        /// <summary>kafka block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#kafka IotTopicRule#kafka}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kafka", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionKafka\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionKafka? Kafka
        {
            get;
            set;
        }

        /// <summary>kinesis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#kinesis IotTopicRule#kinesis}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesis", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionKinesis\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionKinesis? Kinesis
        {
            get;
            set;
        }

        /// <summary>lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#lambda IotTopicRule#lambda}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionLambda\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionLambda? Lambda
        {
            get;
            set;
        }

        /// <summary>republish block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#republish IotTopicRule#republish}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "republish", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionRepublish\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionRepublish? Republish
        {
            get;
            set;
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#s3 IotTopicRule#s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionS3\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionS3? S3
        {
            get;
            set;
        }

        /// <summary>sns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#sns IotTopicRule#sns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sns", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionSns\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionSns? Sns
        {
            get;
            set;
        }

        /// <summary>sqs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#sqs IotTopicRule#sqs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqs", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionSqs\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionSqs? Sqs
        {
            get;
            set;
        }

        /// <summary>step_functions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#step_functions IotTopicRule#step_functions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepFunctions", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionStepFunctions\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionStepFunctions? StepFunctions
        {
            get;
            set;
        }

        /// <summary>timestream block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#timestream IotTopicRule#timestream}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timestream", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionTimestream\"}", isOptional: true)]
        public aws.IotTopicRule.IIotTopicRuleErrorActionTimestream? Timestream
        {
            get;
            set;
        }
    }
}
