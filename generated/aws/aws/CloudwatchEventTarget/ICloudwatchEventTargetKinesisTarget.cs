using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventTarget
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetKinesisTarget), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTargetKinesisTarget")]
    public interface ICloudwatchEventTargetKinesisTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#partition_key_path CloudwatchEventTarget#partition_key_path}.</summary>
        [JsiiProperty(name: "partitionKeyPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PartitionKeyPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetKinesisTarget), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTargetKinesisTarget")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventTarget.ICloudwatchEventTargetKinesisTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#partition_key_path CloudwatchEventTarget#partition_key_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "partitionKeyPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PartitionKeyPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
