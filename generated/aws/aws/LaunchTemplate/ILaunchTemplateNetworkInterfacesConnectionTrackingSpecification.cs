using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateNetworkInterfacesConnectionTrackingSpecification), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateNetworkInterfacesConnectionTrackingSpecification")]
    public interface ILaunchTemplateNetworkInterfacesConnectionTrackingSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#tcp_established_timeout LaunchTemplate#tcp_established_timeout}.</summary>
        [JsiiProperty(name: "tcpEstablishedTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TcpEstablishedTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#udp_stream_timeout LaunchTemplate#udp_stream_timeout}.</summary>
        [JsiiProperty(name: "udpStreamTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UdpStreamTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#udp_timeout LaunchTemplate#udp_timeout}.</summary>
        [JsiiProperty(name: "udpTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UdpTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateNetworkInterfacesConnectionTrackingSpecification), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateNetworkInterfacesConnectionTrackingSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesConnectionTrackingSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#tcp_established_timeout LaunchTemplate#tcp_established_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tcpEstablishedTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TcpEstablishedTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#udp_stream_timeout LaunchTemplate#udp_stream_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "udpStreamTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UdpStreamTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#udp_timeout LaunchTemplate#udp_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "udpTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UdpTimeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
