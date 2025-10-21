using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeLogConfigurationCloudwatchLogsLogDestination")]
    public class PipesPipeLogConfigurationCloudwatchLogsLogDestination : aws.PipesPipe.IPipesPipeLogConfigurationCloudwatchLogsLogDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#log_group_arn PipesPipe#log_group_arn}.</summary>
        [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupArn
        {
            get;
            set;
        }
    }
}
