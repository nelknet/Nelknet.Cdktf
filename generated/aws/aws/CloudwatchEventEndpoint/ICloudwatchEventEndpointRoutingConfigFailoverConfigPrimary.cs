using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventEndpoint
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventEndpointRoutingConfigFailoverConfigPrimary), fullyQualifiedName: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigPrimary")]
    public interface ICloudwatchEventEndpointRoutingConfigFailoverConfigPrimary
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#health_check CloudwatchEventEndpoint#health_check}.</summary>
        [JsiiProperty(name: "healthCheck", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthCheck
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventEndpointRoutingConfigFailoverConfigPrimary), fullyQualifiedName: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigPrimary")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigPrimary
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#health_check CloudwatchEventEndpoint#health_check}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheck", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthCheck
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
