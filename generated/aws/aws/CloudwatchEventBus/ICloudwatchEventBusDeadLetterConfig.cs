using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventBus
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventBusDeadLetterConfig), fullyQualifiedName: "aws.cloudwatchEventBus.CloudwatchEventBusDeadLetterConfig")]
    public interface ICloudwatchEventBusDeadLetterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus#arn CloudwatchEventBus#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Arn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventBusDeadLetterConfig), fullyQualifiedName: "aws.cloudwatchEventBus.CloudwatchEventBusDeadLetterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventBus.ICloudwatchEventBusDeadLetterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus#arn CloudwatchEventBus#arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Arn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
