using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ServiceDiscoveryService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.serviceDiscoveryService.ServiceDiscoveryServiceDnsConfigDnsRecords")]
    public class ServiceDiscoveryServiceDnsConfigDnsRecords : aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfigDnsRecords
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#ttl ServiceDiscoveryService#ttl}.</summary>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        public double Ttl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#type ServiceDiscoveryService#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
