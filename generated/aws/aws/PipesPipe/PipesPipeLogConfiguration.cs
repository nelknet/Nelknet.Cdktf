using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeLogConfiguration")]
    public class PipesPipeLogConfiguration : aws.PipesPipe.IPipesPipeLogConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#level PipesPipe#level}.</summary>
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}")]
        public string Level
        {
            get;
            set;
        }

        /// <summary>cloudwatch_logs_log_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#cloudwatch_logs_log_destination PipesPipe#cloudwatch_logs_log_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsLogDestination", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationCloudwatchLogsLogDestination\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeLogConfigurationCloudwatchLogsLogDestination? CloudwatchLogsLogDestination
        {
            get;
            set;
        }

        /// <summary>firehose_log_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#firehose_log_destination PipesPipe#firehose_log_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firehoseLogDestination", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationFirehoseLogDestination\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeLogConfigurationFirehoseLogDestination? FirehoseLogDestination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#include_execution_data PipesPipe#include_execution_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeExecutionData", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludeExecutionData
        {
            get;
            set;
        }

        /// <summary>s3_log_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#s3_log_destination PipesPipe#s3_log_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3LogDestination", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationS3LogDestination\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeLogConfigurationS3LogDestination? S3LogDestination
        {
            get;
            set;
        }
    }
}
