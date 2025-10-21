using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventEndpoint
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventEndpointRoutingConfigFailoverConfig), fullyQualifiedName: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfig")]
    public interface ICloudwatchEventEndpointRoutingConfigFailoverConfig
    {
        /// <summary>primary block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#primary CloudwatchEventEndpoint#primary}
        /// </remarks>
        [JsiiProperty(name: "primary", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigPrimary\"}")]
        aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigPrimary Primary
        {
            get;
        }

        /// <summary>secondary block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#secondary CloudwatchEventEndpoint#secondary}
        /// </remarks>
        [JsiiProperty(name: "secondary", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigSecondary\"}")]
        aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigSecondary Secondary
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventEndpointRoutingConfigFailoverConfig), fullyQualifiedName: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>primary block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#primary CloudwatchEventEndpoint#primary}
            /// </remarks>
            [JsiiProperty(name: "primary", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigPrimary\"}")]
            public aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigPrimary Primary
            {
                get => GetInstanceProperty<aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigPrimary>()!;
            }

            /// <summary>secondary block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#secondary CloudwatchEventEndpoint#secondary}
            /// </remarks>
            [JsiiProperty(name: "secondary", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigSecondary\"}")]
            public aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigSecondary Secondary
            {
                get => GetInstanceProperty<aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigSecondary>()!;
            }
        }
    }
}
