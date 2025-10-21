using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvschatLoggingConfiguration
{
    [JsiiInterface(nativeType: typeof(IIvschatLoggingConfigurationDestinationConfigurationFirehose), fullyQualifiedName: "aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationFirehose")]
    public interface IIvschatLoggingConfigurationDestinationConfigurationFirehose
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#delivery_stream_name IvschatLoggingConfiguration#delivery_stream_name}.</summary>
        [JsiiProperty(name: "deliveryStreamName", typeJson: "{\"primitive\":\"string\"}")]
        string DeliveryStreamName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIvschatLoggingConfigurationDestinationConfigurationFirehose), fullyQualifiedName: "aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationFirehose")]
        internal sealed class _Proxy : DeputyBase, aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationFirehose
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#delivery_stream_name IvschatLoggingConfiguration#delivery_stream_name}.</summary>
            [JsiiProperty(name: "deliveryStreamName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeliveryStreamName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
