using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventConnection
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventConnectionInvocationConnectivityParametersResourceParameters), fullyQualifiedName: "aws.cloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParametersResourceParameters")]
    public interface ICloudwatchEventConnectionInvocationConnectivityParametersResourceParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#resource_configuration_arn CloudwatchEventConnection#resource_configuration_arn}.</summary>
        [JsiiProperty(name: "resourceConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceConfigurationArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventConnectionInvocationConnectivityParametersResourceParameters), fullyQualifiedName: "aws.cloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParametersResourceParameters")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventConnection.ICloudwatchEventConnectionInvocationConnectivityParametersResourceParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#resource_configuration_arn CloudwatchEventConnection#resource_configuration_arn}.</summary>
            [JsiiProperty(name: "resourceConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceConfigurationArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
