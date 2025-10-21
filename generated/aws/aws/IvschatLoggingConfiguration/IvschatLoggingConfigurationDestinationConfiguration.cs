using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvschatLoggingConfiguration
{
    [JsiiByValue(fqn: "aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfiguration")]
    public class IvschatLoggingConfigurationDestinationConfiguration : aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfiguration
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#cloudwatch_logs IvschatLoggingConfiguration#cloudwatch_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs\"}", isOptional: true)]
        public aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs? CloudwatchLogs
        {
            get;
            set;
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#firehose IvschatLoggingConfiguration#firehose}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationFirehose\"}", isOptional: true)]
        public aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationFirehose? Firehose
        {
            get;
            set;
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#s3 IvschatLoggingConfiguration#s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationS3\"}", isOptional: true)]
        public aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationS3? S3
        {
            get;
            set;
        }
    }
}
