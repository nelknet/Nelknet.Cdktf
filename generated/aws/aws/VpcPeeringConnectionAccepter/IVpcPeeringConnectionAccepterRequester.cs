using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcPeeringConnectionAccepter
{
    [JsiiInterface(nativeType: typeof(IVpcPeeringConnectionAccepterRequester), fullyQualifiedName: "aws.vpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterRequester")]
    public interface IVpcPeeringConnectionAccepterRequester
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter#allow_remote_vpc_dns_resolution VpcPeeringConnectionAccepterA#allow_remote_vpc_dns_resolution}.</summary>
        [JsiiProperty(name: "allowRemoteVpcDnsResolution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowRemoteVpcDnsResolution
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcPeeringConnectionAccepterRequester), fullyQualifiedName: "aws.vpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterRequester")]
        internal sealed class _Proxy : DeputyBase, aws.VpcPeeringConnectionAccepter.IVpcPeeringConnectionAccepterRequester
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter#allow_remote_vpc_dns_resolution VpcPeeringConnectionAccepterA#allow_remote_vpc_dns_resolution}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowRemoteVpcDnsResolution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowRemoteVpcDnsResolution
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
