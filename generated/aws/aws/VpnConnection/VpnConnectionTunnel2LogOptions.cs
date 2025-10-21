using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpnConnection
{
    [JsiiByValue(fqn: "aws.vpnConnection.VpnConnectionTunnel2LogOptions")]
    public class VpnConnectionTunnel2LogOptions : aws.VpnConnection.IVpnConnectionTunnel2LogOptions
    {
        /// <summary>cloudwatch_log_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#cloudwatch_log_options VpnConnection#cloudwatch_log_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogOptions", typeJson: "{\"fqn\":\"aws.vpnConnection.VpnConnectionTunnel2LogOptionsCloudwatchLogOptions\"}", isOptional: true)]
        public aws.VpnConnection.IVpnConnectionTunnel2LogOptionsCloudwatchLogOptions? CloudwatchLogOptions
        {
            get;
            set;
        }
    }
}
