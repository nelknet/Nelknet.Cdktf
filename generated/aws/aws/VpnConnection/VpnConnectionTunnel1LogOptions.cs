using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpnConnection
{
    [JsiiByValue(fqn: "aws.vpnConnection.VpnConnectionTunnel1LogOptions")]
    public class VpnConnectionTunnel1LogOptions : aws.VpnConnection.IVpnConnectionTunnel1LogOptions
    {
        /// <summary>cloudwatch_log_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#cloudwatch_log_options VpnConnection#cloudwatch_log_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogOptions", typeJson: "{\"fqn\":\"aws.vpnConnection.VpnConnectionTunnel1LogOptionsCloudwatchLogOptions\"}", isOptional: true)]
        public aws.VpnConnection.IVpnConnectionTunnel1LogOptionsCloudwatchLogOptions? CloudwatchLogOptions
        {
            get;
            set;
        }
    }
}
