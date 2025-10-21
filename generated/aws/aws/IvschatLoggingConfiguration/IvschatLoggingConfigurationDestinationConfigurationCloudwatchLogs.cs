using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvschatLoggingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs")]
    public class IvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs : aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#log_group_name IvschatLoggingConfiguration#log_group_name}.</summary>
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupName
        {
            get;
            set;
        }
    }
}
