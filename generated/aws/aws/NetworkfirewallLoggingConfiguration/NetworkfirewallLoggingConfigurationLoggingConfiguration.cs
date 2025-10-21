using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallLoggingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewallLoggingConfiguration.NetworkfirewallLoggingConfigurationLoggingConfiguration")]
    public class NetworkfirewallLoggingConfigurationLoggingConfiguration : aws.NetworkfirewallLoggingConfiguration.INetworkfirewallLoggingConfigurationLoggingConfiguration
    {
        private object _logDestinationConfig;

        /// <summary>log_destination_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_logging_configuration#log_destination_config NetworkfirewallLoggingConfiguration#log_destination_config}
        /// </remarks>
        [JsiiProperty(name: "logDestinationConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallLoggingConfiguration.NetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig\"},\"kind\":\"array\"}}]}}")]
        public object LogDestinationConfig
        {
            get => _logDestinationConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.NetworkfirewallLoggingConfiguration.INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.NetworkfirewallLoggingConfiguration.INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.NetworkfirewallLoggingConfiguration.INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logDestinationConfig = value;
            }
        }
    }
}
