using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeLogConfiguration), fullyQualifiedName: "aws.pipesPipe.PipesPipeLogConfiguration")]
    public interface IPipesPipeLogConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#level PipesPipe#level}.</summary>
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}")]
        string Level
        {
            get;
        }

        /// <summary>cloudwatch_logs_log_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#cloudwatch_logs_log_destination PipesPipe#cloudwatch_logs_log_destination}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogsLogDestination", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationCloudwatchLogsLogDestination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeLogConfigurationCloudwatchLogsLogDestination? CloudwatchLogsLogDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>firehose_log_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#firehose_log_destination PipesPipe#firehose_log_destination}
        /// </remarks>
        [JsiiProperty(name: "firehoseLogDestination", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationFirehoseLogDestination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeLogConfigurationFirehoseLogDestination? FirehoseLogDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#include_execution_data PipesPipe#include_execution_data}.</summary>
        [JsiiProperty(name: "includeExecutionData", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludeExecutionData
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_log_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#s3_log_destination PipesPipe#s3_log_destination}
        /// </remarks>
        [JsiiProperty(name: "s3LogDestination", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationS3LogDestination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeLogConfigurationS3LogDestination? S3LogDestination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeLogConfiguration), fullyQualifiedName: "aws.pipesPipe.PipesPipeLogConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeLogConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#level PipesPipe#level}.</summary>
            [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}")]
            public string Level
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cloudwatch_logs_log_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#cloudwatch_logs_log_destination PipesPipe#cloudwatch_logs_log_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogsLogDestination", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationCloudwatchLogsLogDestination\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeLogConfigurationCloudwatchLogsLogDestination? CloudwatchLogsLogDestination
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeLogConfigurationCloudwatchLogsLogDestination?>();
            }

            /// <summary>firehose_log_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#firehose_log_destination PipesPipe#firehose_log_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firehoseLogDestination", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationFirehoseLogDestination\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeLogConfigurationFirehoseLogDestination? FirehoseLogDestination
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeLogConfigurationFirehoseLogDestination?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#include_execution_data PipesPipe#include_execution_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeExecutionData", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludeExecutionData
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>s3_log_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#s3_log_destination PipesPipe#s3_log_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3LogDestination", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationS3LogDestination\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeLogConfigurationS3LogDestination? S3LogDestination
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeLogConfigurationS3LogDestination?>();
            }
        }
    }
}
