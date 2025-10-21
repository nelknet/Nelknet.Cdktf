using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventEndpoint
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventEndpointReplicationConfig), fullyQualifiedName: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointReplicationConfig")]
    public interface ICloudwatchEventEndpointReplicationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#state CloudwatchEventEndpoint#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventEndpointReplicationConfig), fullyQualifiedName: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointReplicationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointReplicationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#state CloudwatchEventEndpoint#state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
