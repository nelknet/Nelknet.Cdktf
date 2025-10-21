using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    [JsiiClass(nativeType: typeof(aws.IotTopicRule.IotTopicRuleErrorActionOutputReference), fullyQualifiedName: "aws.iotTopicRule.IotTopicRuleErrorActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotTopicRuleErrorActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotTopicRuleErrorActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRuleErrorActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRuleErrorActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchAlarm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchAlarm\"}}]")]
        public virtual void PutCloudwatchAlarm(aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchAlarm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchAlarm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCloudwatchLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchLogs\"}}]")]
        public virtual void PutCloudwatchLogs(aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCloudwatchMetric", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchMetric\"}}]")]
        public virtual void PutCloudwatchMetric(aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchMetric @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchMetric)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDynamodb", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodb\"}}]")]
        public virtual void PutDynamodb(aws.IotTopicRule.IIotTopicRuleErrorActionDynamodb @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionDynamodb)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDynamodbv2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodbv2\"}}]")]
        public virtual void PutDynamodbv2(aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putElasticsearch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionElasticsearch\"}}]")]
        public virtual void PutElasticsearch(aws.IotTopicRule.IIotTopicRuleErrorActionElasticsearch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionElasticsearch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFirehose", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionFirehose\"}}]")]
        public virtual void PutFirehose(aws.IotTopicRule.IIotTopicRuleErrorActionFirehose @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionFirehose)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionHttp\"}}]")]
        public virtual void PutHttp(aws.IotTopicRule.IIotTopicRuleErrorActionHttp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionHttp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIotAnalytics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionIotAnalytics\"}}]")]
        public virtual void PutIotAnalytics(aws.IotTopicRule.IIotTopicRuleErrorActionIotAnalytics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionIotAnalytics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIotEvents", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionIotEvents\"}}]")]
        public virtual void PutIotEvents(aws.IotTopicRule.IIotTopicRuleErrorActionIotEvents @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionIotEvents)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKafka", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionKafka\"}}]")]
        public virtual void PutKafka(aws.IotTopicRule.IIotTopicRuleErrorActionKafka @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionKafka)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesis", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionKinesis\"}}]")]
        public virtual void PutKinesis(aws.IotTopicRule.IIotTopicRuleErrorActionKinesis @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionKinesis)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambda", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionLambda\"}}]")]
        public virtual void PutLambda(aws.IotTopicRule.IIotTopicRuleErrorActionLambda @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionLambda)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRepublish", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionRepublish\"}}]")]
        public virtual void PutRepublish(aws.IotTopicRule.IIotTopicRuleErrorActionRepublish @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionRepublish)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionS3\"}}]")]
        public virtual void PutS3(aws.IotTopicRule.IIotTopicRuleErrorActionS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionS3)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionSns\"}}]")]
        public virtual void PutSns(aws.IotTopicRule.IIotTopicRuleErrorActionSns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionSns)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionSqs\"}}]")]
        public virtual void PutSqs(aws.IotTopicRule.IIotTopicRuleErrorActionSqs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionSqs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepFunctions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionStepFunctions\"}}]")]
        public virtual void PutStepFunctions(aws.IotTopicRule.IIotTopicRuleErrorActionStepFunctions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionStepFunctions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimestream", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionTimestream\"}}]")]
        public virtual void PutTimestream(aws.IotTopicRule.IIotTopicRuleErrorActionTimestream @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotTopicRule.IIotTopicRuleErrorActionTimestream)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchAlarm")]
        public virtual void ResetCloudwatchAlarm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudwatchLogs")]
        public virtual void ResetCloudwatchLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudwatchMetric")]
        public virtual void ResetCloudwatchMetric()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodb")]
        public virtual void ResetDynamodb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodbv2")]
        public virtual void ResetDynamodbv2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearch")]
        public virtual void ResetElasticsearch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirehose")]
        public virtual void ResetFirehose()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttp")]
        public virtual void ResetHttp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIotAnalytics")]
        public virtual void ResetIotAnalytics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIotEvents")]
        public virtual void ResetIotEvents()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKafka")]
        public virtual void ResetKafka()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesis")]
        public virtual void ResetKinesis()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambda")]
        public virtual void ResetLambda()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepublish")]
        public virtual void ResetRepublish()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3")]
        public virtual void ResetS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSns")]
        public virtual void ResetSns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqs")]
        public virtual void ResetSqs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepFunctions")]
        public virtual void ResetStepFunctions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimestream")]
        public virtual void ResetTimestream()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchAlarmOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionCloudwatchAlarmOutputReference CloudwatchAlarm
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionCloudwatchAlarmOutputReference>()!;
        }

        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchLogsOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionCloudwatchLogsOutputReference CloudwatchLogs
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionCloudwatchLogsOutputReference>()!;
        }

        [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchMetricOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionCloudwatchMetricOutputReference CloudwatchMetric
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionCloudwatchMetricOutputReference>()!;
        }

        [JsiiProperty(name: "dynamodb", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodbOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionDynamodbOutputReference Dynamodb
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionDynamodbOutputReference>()!;
        }

        [JsiiProperty(name: "dynamodbv2", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodbv2OutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionDynamodbv2OutputReference Dynamodbv2
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionDynamodbv2OutputReference>()!;
        }

        [JsiiProperty(name: "elasticsearch", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionElasticsearchOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionElasticsearchOutputReference Elasticsearch
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionElasticsearchOutputReference>()!;
        }

        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionFirehoseOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionFirehoseOutputReference Firehose
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionFirehoseOutputReference>()!;
        }

        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionHttpOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionHttpOutputReference Http
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionHttpOutputReference>()!;
        }

        [JsiiProperty(name: "iotAnalytics", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionIotAnalyticsOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionIotAnalyticsOutputReference IotAnalytics
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionIotAnalyticsOutputReference>()!;
        }

        [JsiiProperty(name: "iotEvents", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionIotEventsOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionIotEventsOutputReference IotEvents
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionIotEventsOutputReference>()!;
        }

        [JsiiProperty(name: "kafka", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionKafkaOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionKafkaOutputReference Kafka
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionKafkaOutputReference>()!;
        }

        [JsiiProperty(name: "kinesis", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionKinesisOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionKinesisOutputReference Kinesis
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionKinesisOutputReference>()!;
        }

        [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionLambdaOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionLambdaOutputReference Lambda
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionLambdaOutputReference>()!;
        }

        [JsiiProperty(name: "republish", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionRepublishOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionRepublishOutputReference Republish
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionRepublishOutputReference>()!;
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionS3OutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionS3OutputReference S3
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionS3OutputReference>()!;
        }

        [JsiiProperty(name: "sns", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionSnsOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionSnsOutputReference Sns
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionSnsOutputReference>()!;
        }

        [JsiiProperty(name: "sqs", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionSqsOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionSqsOutputReference Sqs
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionSqsOutputReference>()!;
        }

        [JsiiProperty(name: "stepFunctions", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionStepFunctionsOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionStepFunctionsOutputReference StepFunctions
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionStepFunctionsOutputReference>()!;
        }

        [JsiiProperty(name: "timestream", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionTimestreamOutputReference\"}")]
        public virtual aws.IotTopicRule.IotTopicRuleErrorActionTimestreamOutputReference Timestream
        {
            get => GetInstanceProperty<aws.IotTopicRule.IotTopicRuleErrorActionTimestreamOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchAlarmInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchAlarm\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchAlarm? CloudwatchAlarmInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchAlarm?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchLogs\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchLogs? CloudwatchLogsInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchMetricInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionCloudwatchMetric\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchMetric? CloudwatchMetricInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionCloudwatchMetric?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodb\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionDynamodb? DynamodbInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionDynamodb?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbv2Input", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionDynamodbv2\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2? Dynamodbv2Input
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionDynamodbv2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionElasticsearch\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionElasticsearch? ElasticsearchInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionElasticsearch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firehoseInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionFirehose\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionFirehose? FirehoseInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionFirehose?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionHttp\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionHttp? HttpInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionHttp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iotAnalyticsInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionIotAnalytics\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionIotAnalytics? IotAnalyticsInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionIotAnalytics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iotEventsInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionIotEvents\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionIotEvents? IotEventsInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionIotEvents?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kafkaInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionKafka\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionKafka? KafkaInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionKafka?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionKinesis\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionKinesis? KinesisInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionKinesis?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionLambda\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionLambda? LambdaInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionLambda?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "republishInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionRepublish\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionRepublish? RepublishInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionRepublish?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionS3\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionS3? S3Input
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snsInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionSns\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionSns? SnsInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionSns?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqsInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionSqs\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionSqs? SqsInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionSqs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepFunctionsInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionStepFunctions\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionStepFunctions? StepFunctionsInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionStepFunctions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timestreamInput", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorActionTimestream\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorActionTimestream? TimestreamInput
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorActionTimestream?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.iotTopicRule.IotTopicRuleErrorAction\"}", isOptional: true)]
        public virtual aws.IotTopicRule.IIotTopicRuleErrorAction? InternalValue
        {
            get => GetInstanceProperty<aws.IotTopicRule.IIotTopicRuleErrorAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
