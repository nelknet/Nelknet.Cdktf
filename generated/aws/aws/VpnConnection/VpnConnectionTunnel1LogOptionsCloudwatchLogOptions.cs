using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpnConnection
{
    [JsiiByValue(fqn: "aws.vpnConnection.VpnConnectionTunnel1LogOptionsCloudwatchLogOptions")]
    public class VpnConnectionTunnel1LogOptionsCloudwatchLogOptions : aws.VpnConnection.IVpnConnectionTunnel1LogOptionsCloudwatchLogOptions
    {
        private object? _logEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#log_enabled VpnConnection#log_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? LogEnabled
        {
            get => _logEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#log_group_arn VpnConnection#log_group_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroupArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#log_output_format VpnConnection#log_output_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logOutputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogOutputFormat
        {
            get;
            set;
        }
    }
}
