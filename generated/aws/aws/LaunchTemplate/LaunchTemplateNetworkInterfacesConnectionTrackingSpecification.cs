using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiByValue(fqn: "aws.launchTemplate.LaunchTemplateNetworkInterfacesConnectionTrackingSpecification")]
    public class LaunchTemplateNetworkInterfacesConnectionTrackingSpecification : aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesConnectionTrackingSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#tcp_established_timeout LaunchTemplate#tcp_established_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tcpEstablishedTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TcpEstablishedTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#udp_stream_timeout LaunchTemplate#udp_stream_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "udpStreamTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UdpStreamTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#udp_timeout LaunchTemplate#udp_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "udpTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UdpTimeout
        {
            get;
            set;
        }
    }
}
