using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventEndpoint
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventEndpointEventBus), fullyQualifiedName: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointEventBus")]
    public interface ICloudwatchEventEndpointEventBus
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#event_bus_arn CloudwatchEventEndpoint#event_bus_arn}.</summary>
        [JsiiProperty(name: "eventBusArn", typeJson: "{\"primitive\":\"string\"}")]
        string EventBusArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventEndpointEventBus), fullyQualifiedName: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointEventBus")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointEventBus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#event_bus_arn CloudwatchEventEndpoint#event_bus_arn}.</summary>
            [JsiiProperty(name: "eventBusArn", typeJson: "{\"primitive\":\"string\"}")]
            public string EventBusArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
