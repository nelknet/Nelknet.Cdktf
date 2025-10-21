using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvschatLoggingConfiguration
{
    [JsiiInterface(nativeType: typeof(IIvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs), fullyQualifiedName: "aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs")]
    public interface IIvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#log_group_name IvschatLoggingConfiguration#log_group_name}.</summary>
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs), fullyQualifiedName: "aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs")]
        internal sealed class _Proxy : DeputyBase, aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#log_group_name IvschatLoggingConfiguration#log_group_name}.</summary>
            [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
