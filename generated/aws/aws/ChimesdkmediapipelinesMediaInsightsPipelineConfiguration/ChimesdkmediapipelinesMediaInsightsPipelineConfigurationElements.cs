using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElements")]
    public class ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElements : aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationElements
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#type ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>amazon_transcribe_call_analytics_processor_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#amazon_transcribe_call_analytics_processor_configuration ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#amazon_transcribe_call_analytics_processor_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amazonTranscribeCallAnalyticsProcessorConfiguration", typeJson: "{\"fqn\":\"aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsAmazonTranscribeCallAnalyticsProcessorConfiguration\"}", isOptional: true)]
        public aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsAmazonTranscribeCallAnalyticsProcessorConfiguration? AmazonTranscribeCallAnalyticsProcessorConfiguration
        {
            get;
            set;
        }

        /// <summary>amazon_transcribe_processor_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#amazon_transcribe_processor_configuration ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#amazon_transcribe_processor_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amazonTranscribeProcessorConfiguration", typeJson: "{\"fqn\":\"aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsAmazonTranscribeProcessorConfiguration\"}", isOptional: true)]
        public aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsAmazonTranscribeProcessorConfiguration? AmazonTranscribeProcessorConfiguration
        {
            get;
            set;
        }

        /// <summary>kinesis_data_stream_sink_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#kinesis_data_stream_sink_configuration ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#kinesis_data_stream_sink_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisDataStreamSinkConfiguration", typeJson: "{\"fqn\":\"aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsKinesisDataStreamSinkConfiguration\"}", isOptional: true)]
        public aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsKinesisDataStreamSinkConfiguration? KinesisDataStreamSinkConfiguration
        {
            get;
            set;
        }

        /// <summary>lambda_function_sink_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#lambda_function_sink_configuration ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#lambda_function_sink_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionSinkConfiguration", typeJson: "{\"fqn\":\"aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsLambdaFunctionSinkConfiguration\"}", isOptional: true)]
        public aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsLambdaFunctionSinkConfiguration? LambdaFunctionSinkConfiguration
        {
            get;
            set;
        }

        /// <summary>s3_recording_sink_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#s3_recording_sink_configuration ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#s3_recording_sink_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3RecordingSinkConfiguration", typeJson: "{\"fqn\":\"aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsS3RecordingSinkConfiguration\"}", isOptional: true)]
        public aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsS3RecordingSinkConfiguration? S3RecordingSinkConfiguration
        {
            get;
            set;
        }

        /// <summary>sns_topic_sink_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#sns_topic_sink_configuration ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#sns_topic_sink_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snsTopicSinkConfiguration", typeJson: "{\"fqn\":\"aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsSnsTopicSinkConfiguration\"}", isOptional: true)]
        public aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsSnsTopicSinkConfiguration? SnsTopicSinkConfiguration
        {
            get;
            set;
        }

        /// <summary>sqs_queue_sink_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#sqs_queue_sink_configuration ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#sqs_queue_sink_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqsQueueSinkConfiguration", typeJson: "{\"fqn\":\"aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsSqsQueueSinkConfiguration\"}", isOptional: true)]
        public aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsSqsQueueSinkConfiguration? SqsQueueSinkConfiguration
        {
            get;
            set;
        }

        /// <summary>voice_analytics_processor_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#voice_analytics_processor_configuration ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#voice_analytics_processor_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "voiceAnalyticsProcessorConfiguration", typeJson: "{\"fqn\":\"aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsVoiceAnalyticsProcessorConfiguration\"}", isOptional: true)]
        public aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsVoiceAnalyticsProcessorConfiguration? VoiceAnalyticsProcessorConfiguration
        {
            get;
            set;
        }
    }
}
