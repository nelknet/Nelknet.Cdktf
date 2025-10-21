using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpnConnection
{
    [JsiiInterface(nativeType: typeof(IVpnConnectionTunnel2LogOptionsCloudwatchLogOptions), fullyQualifiedName: "aws.vpnConnection.VpnConnectionTunnel2LogOptionsCloudwatchLogOptions")]
    public interface IVpnConnectionTunnel2LogOptionsCloudwatchLogOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#log_enabled VpnConnection#log_enabled}.</summary>
        [JsiiProperty(name: "logEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#log_group_arn VpnConnection#log_group_arn}.</summary>
        [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogGroupArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#log_output_format VpnConnection#log_output_format}.</summary>
        [JsiiProperty(name: "logOutputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogOutputFormat
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnConnectionTunnel2LogOptionsCloudwatchLogOptions), fullyQualifiedName: "aws.vpnConnection.VpnConnectionTunnel2LogOptionsCloudwatchLogOptions")]
        internal sealed class _Proxy : DeputyBase, aws.VpnConnection.IVpnConnectionTunnel2LogOptionsCloudwatchLogOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#log_enabled VpnConnection#log_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? LogEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#log_group_arn VpnConnection#log_group_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogGroupArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#log_output_format VpnConnection#log_output_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logOutputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogOutputFormat
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
