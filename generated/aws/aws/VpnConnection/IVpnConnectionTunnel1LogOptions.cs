using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpnConnection
{
    [JsiiInterface(nativeType: typeof(IVpnConnectionTunnel1LogOptions), fullyQualifiedName: "aws.vpnConnection.VpnConnectionTunnel1LogOptions")]
    public interface IVpnConnectionTunnel1LogOptions
    {
        /// <summary>cloudwatch_log_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#cloudwatch_log_options VpnConnection#cloudwatch_log_options}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogOptions", typeJson: "{\"fqn\":\"aws.vpnConnection.VpnConnectionTunnel1LogOptionsCloudwatchLogOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.VpnConnection.IVpnConnectionTunnel1LogOptionsCloudwatchLogOptions? CloudwatchLogOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnConnectionTunnel1LogOptions), fullyQualifiedName: "aws.vpnConnection.VpnConnectionTunnel1LogOptions")]
        internal sealed class _Proxy : DeputyBase, aws.VpnConnection.IVpnConnectionTunnel1LogOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_log_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#cloudwatch_log_options VpnConnection#cloudwatch_log_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogOptions", typeJson: "{\"fqn\":\"aws.vpnConnection.VpnConnectionTunnel1LogOptionsCloudwatchLogOptions\"}", isOptional: true)]
            public aws.VpnConnection.IVpnConnectionTunnel1LogOptionsCloudwatchLogOptions? CloudwatchLogOptions
            {
                get => GetInstanceProperty<aws.VpnConnection.IVpnConnectionTunnel1LogOptionsCloudwatchLogOptions?>();
            }
        }
    }
}
