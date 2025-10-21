using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorAction), fullyQualifiedName: "aws.iotTopicRule.IotTopicRuleErrorAction")]
    public interface IIotTopicRuleErrorAction
    {
        /// <summary>cloudwatch_alarm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#cloudwatch_alarm IotTopicRule#cloudwatch_alarm}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchAlarm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchAlarm? CloudwatchAlarm
        {
            get
            {
                return null;
            }
        }

        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#cloudwatch_logs IotTopicRule#cloudwatch_logs}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchLogs? CloudwatchLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>cloudwatch_metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#cloudwatch_metric IotTopicRule#cloudwatch_metric}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchMetric\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchMetric? CloudwatchMetric
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamodb block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#dynamodb IotTopicRule#dynamodb}
        /// </remarks>
        [JsiiProperty(name: "dynamodb", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodb\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionDynamodb? Dynamodb
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamodbv2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#dynamodbv2 IotTopicRule#dynamodbv2}
        /// </remarks>
        [JsiiProperty(name: "dynamodbv2", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodbv2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2? Dynamodbv2
        {
            get
            {
                return null;
            }
        }

        /// <summary>elasticsearch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#elasticsearch IotTopicRule#elasticsearch}
        /// </remarks>
        [JsiiProperty(name: "elasticsearch", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionElasticsearch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionElasticsearch? Elasticsearch
        {
            get
            {
                return null;
            }
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#firehose IotTopicRule#firehose}
        /// </remarks>
        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionFirehose\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionFirehose? Firehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#http IotTopicRule#http}
        /// </remarks>
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionHttp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionHttp? Http
        {
            get
            {
                return null;
            }
        }

        /// <summary>iot_analytics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#iot_analytics IotTopicRule#iot_analytics}
        /// </remarks>
        [JsiiProperty(name: "iotAnalytics", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionIotAnalytics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionIotAnalytics? IotAnalytics
        {
            get
            {
                return null;
            }
        }

        /// <summary>iot_events block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#iot_events IotTopicRule#iot_events}
        /// </remarks>
        [JsiiProperty(name: "iotEvents", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionIotEvents\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionIotEvents? IotEvents
        {
            get
            {
                return null;
            }
        }

        /// <summary>kafka block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#kafka IotTopicRule#kafka}
        /// </remarks>
        [JsiiProperty(name: "kafka", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionKafka\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionKafka? Kafka
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#kinesis IotTopicRule#kinesis}
        /// </remarks>
        [JsiiProperty(name: "kinesis", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionKinesis\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionKinesis? Kinesis
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#lambda IotTopicRule#lambda}
        /// </remarks>
        [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionLambda\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionLambda? Lambda
        {
            get
            {
                return null;
            }
        }

        /// <summary>republish block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#republish IotTopicRule#republish}
        /// </remarks>
        [JsiiProperty(name: "republish", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionRepublish\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionRepublish? Republish
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#s3 IotTopicRule#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionS3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionS3? S3
        {
            get
            {
                return null;
            }
        }

        /// <summary>sns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#sns IotTopicRule#sns}
        /// </remarks>
        [JsiiProperty(name: "sns", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionSns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionSns? Sns
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#sqs IotTopicRule#sqs}
        /// </remarks>
        [JsiiProperty(name: "sqs", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionSqs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionSqs? Sqs
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_functions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#step_functions IotTopicRule#step_functions}
        /// </remarks>
        [JsiiProperty(name: "stepFunctions", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionStepFunctions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionStepFunctions? StepFunctions
        {
            get
            {
                return null;
            }
        }

        /// <summary>timestream block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#timestream IotTopicRule#timestream}
        /// </remarks>
        [JsiiProperty(name: "timestream", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionTimestream\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotTopicRule.IIotTopicRuleErrorActionTimestream? Timestream
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorAction), fullyQualifiedName: "aws.iotTopicRule.IotTopicRuleErrorAction")]
        internal sealed class _Proxy : DeputyBase, aws.IotTopicRule.IIotTopicRuleErrorAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_alarm block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#cloudwatch_alarm IotTopicRule#cloudwatch_alarm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchAlarm\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchAlarm? CloudwatchAlarm
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchAlarm?>();
            }

            /// <summary>cloudwatch_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#cloudwatch_logs IotTopicRule#cloudwatch_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchLogs\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchLogs? CloudwatchLogs
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchLogs?>();
            }

            /// <summary>cloudwatch_metric block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#cloudwatch_metric IotTopicRule#cloudwatch_metric}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchMetric\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchMetric? CloudwatchMetric
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchMetric?>();
            }

            /// <summary>dynamodb block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#dynamodb IotTopicRule#dynamodb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodb", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodb\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionDynamodb? Dynamodb
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionDynamodb?>();
            }

            /// <summary>dynamodbv2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#dynamodbv2 IotTopicRule#dynamodbv2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodbv2", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodbv2\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2? Dynamodbv2
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2?>();
            }

            /// <summary>elasticsearch block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#elasticsearch IotTopicRule#elasticsearch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "elasticsearch", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionElasticsearch\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionElasticsearch? Elasticsearch
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionElasticsearch?>();
            }

            /// <summary>firehose block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#firehose IotTopicRule#firehose}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionFirehose\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionFirehose? Firehose
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionFirehose?>();
            }

            /// <summary>http block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#http IotTopicRule#http}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionHttp\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionHttp? Http
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionHttp?>();
            }

            /// <summary>iot_analytics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#iot_analytics IotTopicRule#iot_analytics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iotAnalytics", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionIotAnalytics\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionIotAnalytics? IotAnalytics
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionIotAnalytics?>();
            }

            /// <summary>iot_events block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#iot_events IotTopicRule#iot_events}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iotEvents", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionIotEvents\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionIotEvents? IotEvents
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionIotEvents?>();
            }

            /// <summary>kafka block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#kafka IotTopicRule#kafka}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kafka", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionKafka\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionKafka? Kafka
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionKafka?>();
            }

            /// <summary>kinesis block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#kinesis IotTopicRule#kinesis}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesis", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionKinesis\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionKinesis? Kinesis
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionKinesis?>();
            }

            /// <summary>lambda block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#lambda IotTopicRule#lambda}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionLambda\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionLambda? Lambda
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionLambda?>();
            }

            /// <summary>republish block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#republish IotTopicRule#republish}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "republish", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionRepublish\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionRepublish? Republish
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionRepublish?>();
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#s3 IotTopicRule#s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionS3\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionS3? S3
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionS3?>();
            }

            /// <summary>sns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#sns IotTopicRule#sns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sns", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionSns\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionSns? Sns
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionSns?>();
            }

            /// <summary>sqs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#sqs IotTopicRule#sqs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqs", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionSqs\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionSqs? Sqs
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionSqs?>();
            }

            /// <summary>step_functions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#step_functions IotTopicRule#step_functions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepFunctions", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionStepFunctions\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionStepFunctions? StepFunctions
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionStepFunctions?>();
            }

            /// <summary>timestream block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#timestream IotTopicRule#timestream}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timestream", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionTimestream\"}", isOptional: true)]
            public aws.IotTopicRule.IIotTopicRuleErrorActionTimestream? Timestream
            {
                get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionTimestream?>();
            }
        }
    }
}
