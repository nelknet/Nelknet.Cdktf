using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvschatLoggingConfiguration
{
    [JsiiInterface(nativeType: typeof(IIvschatLoggingConfigurationDestinationConfiguration), fullyQualifiedName: "aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfiguration")]
    public interface IIvschatLoggingConfigurationDestinationConfiguration
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#cloudwatch_logs IvschatLoggingConfiguration#cloudwatch_logs}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs? CloudwatchLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#firehose IvschatLoggingConfiguration#firehose}
        /// </remarks>
        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationFirehose\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationFirehose? Firehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#s3 IvschatLoggingConfiguration#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationS3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationS3? S3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIvschatLoggingConfigurationDestinationConfiguration), fullyQualifiedName: "aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#cloudwatch_logs IvschatLoggingConfiguration#cloudwatch_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs\"}", isOptional: true)]
            public aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs? CloudwatchLogs
            {
                get => GetInstanceProperty<aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs?>();
            }

            /// <summary>firehose block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#firehose IvschatLoggingConfiguration#firehose}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationFirehose\"}", isOptional: true)]
            public aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationFirehose? Firehose
            {
                get => GetInstanceProperty<aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationFirehose?>();
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#s3 IvschatLoggingConfiguration#s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationS3\"}", isOptional: true)]
            public aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationS3? S3
            {
                get => GetInstanceProperty<aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationS3?>();
            }
        }
    }
}
