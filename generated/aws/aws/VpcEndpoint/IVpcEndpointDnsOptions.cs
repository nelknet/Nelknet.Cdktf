using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcEndpoint
{
    [JsiiInterface(nativeType: typeof(IVpcEndpointDnsOptions), fullyQualifiedName: "aws.vpcEndpoint.VpcEndpointDnsOptions")]
    public interface IVpcEndpointDnsOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#dns_record_ip_type VpcEndpoint#dns_record_ip_type}.</summary>
        [JsiiProperty(name: "dnsRecordIpType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DnsRecordIpType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#private_dns_only_for_inbound_resolver_endpoint VpcEndpoint#private_dns_only_for_inbound_resolver_endpoint}.</summary>
        [JsiiProperty(name: "privateDnsOnlyForInboundResolverEndpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateDnsOnlyForInboundResolverEndpoint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcEndpointDnsOptions), fullyQualifiedName: "aws.vpcEndpoint.VpcEndpointDnsOptions")]
        internal sealed class _Proxy : DeputyBase, aws.VpcEndpoint.IVpcEndpointDnsOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#dns_record_ip_type VpcEndpoint#dns_record_ip_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsRecordIpType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DnsRecordIpType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#private_dns_only_for_inbound_resolver_endpoint VpcEndpoint#private_dns_only_for_inbound_resolver_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateDnsOnlyForInboundResolverEndpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PrivateDnsOnlyForInboundResolverEndpoint
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
