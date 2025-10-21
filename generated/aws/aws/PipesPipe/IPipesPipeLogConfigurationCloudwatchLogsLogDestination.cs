using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeLogConfigurationCloudwatchLogsLogDestination), fullyQualifiedName: "aws.pipesPipe.PipesPipeLogConfigurationCloudwatchLogsLogDestination")]
    public interface IPipesPipeLogConfigurationCloudwatchLogsLogDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#log_group_arn PipesPipe#log_group_arn}.</summary>
        [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeLogConfigurationCloudwatchLogsLogDestination), fullyQualifiedName: "aws.pipesPipe.PipesPipeLogConfigurationCloudwatchLogsLogDestination")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeLogConfigurationCloudwatchLogsLogDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#log_group_arn PipesPipe#log_group_arn}.</summary>
            [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
