using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallLoggingConfiguration
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallLoggingConfigurationLoggingConfiguration), fullyQualifiedName: "aws.networkfirewallLoggingConfiguration.NetworkfirewallLoggingConfigurationLoggingConfiguration")]
    public interface INetworkfirewallLoggingConfigurationLoggingConfiguration
    {
        /// <summary>log_destination_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_logging_configuration#log_destination_config NetworkfirewallLoggingConfiguration#log_destination_config}
        /// </remarks>
        [JsiiProperty(name: "logDestinationConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallLoggingConfiguration.NetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig\"},\"kind\":\"array\"}}]}}")]
        object LogDestinationConfig
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallLoggingConfigurationLoggingConfiguration), fullyQualifiedName: "aws.networkfirewallLoggingConfiguration.NetworkfirewallLoggingConfigurationLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkfirewallLoggingConfiguration.INetworkfirewallLoggingConfigurationLoggingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>log_destination_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_logging_configuration#log_destination_config NetworkfirewallLoggingConfiguration#log_destination_config}
            /// </remarks>
            [JsiiProperty(name: "logDestinationConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallLoggingConfiguration.NetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig\"},\"kind\":\"array\"}}]}}")]
            public object LogDestinationConfig
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
