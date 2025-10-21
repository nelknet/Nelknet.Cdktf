using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedaccessInstanceLoggingConfiguration
{
    [JsiiByValue(fqn: "aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogs")]
    public class VerifiedaccessInstanceLoggingConfigurationAccessLogs : aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogs
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance_logging_configuration#cloudwatch_logs VerifiedaccessInstanceLoggingConfiguration#cloudwatch_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsCloudwatchLogs\"}", isOptional: true)]
        public aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsCloudwatchLogs? CloudwatchLogs
        {
            get;
            set;
        }

        private object? _includeTrustContext;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance_logging_configuration#include_trust_context VerifiedaccessInstanceLoggingConfiguration#include_trust_context}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeTrustContext", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeTrustContext
        {
            get => _includeTrustContext;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _includeTrustContext = value;
            }
        }

        /// <summary>kinesis_data_firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance_logging_configuration#kinesis_data_firehose VerifiedaccessInstanceLoggingConfiguration#kinesis_data_firehose}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisDataFirehose", typeJson: "{\"fqn\":\"aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsKinesisDataFirehose\"}", isOptional: true)]
        public aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsKinesisDataFirehose? KinesisDataFirehose
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance_logging_configuration#log_version VerifiedaccessInstanceLoggingConfiguration#log_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogVersion
        {
            get;
            set;
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance_logging_configuration#s3 VerifiedaccessInstanceLoggingConfiguration#s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsS3\"}", isOptional: true)]
        public aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsS3? S3
        {
            get;
            set;
        }
    }
}
