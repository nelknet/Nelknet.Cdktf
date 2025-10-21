using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ServiceDiscoveryService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.serviceDiscoveryService.ServiceDiscoveryServiceDnsConfig")]
    public class ServiceDiscoveryServiceDnsConfig : aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfig
    {
        private object _dnsRecords;

        /// <summary>dns_records block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#dns_records ServiceDiscoveryService#dns_records}
        /// </remarks>
        [JsiiProperty(name: "dnsRecords", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceDnsConfigDnsRecords\"},\"kind\":\"array\"}}]}}")]
        public object DnsRecords
        {
            get => _dnsRecords;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfigDnsRecords[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfigDnsRecords).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfigDnsRecords).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dnsRecords = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#namespace_id ServiceDiscoveryService#namespace_id}.</summary>
        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
        public string NamespaceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#routing_policy ServiceDiscoveryService#routing_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoutingPolicy
        {
            get;
            set;
        }
    }
}
