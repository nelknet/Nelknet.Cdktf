using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ServiceDiscoveryService
{
    [JsiiInterface(nativeType: typeof(IServiceDiscoveryServiceDnsConfigDnsRecords), fullyQualifiedName: "aws.serviceDiscoveryService.ServiceDiscoveryServiceDnsConfigDnsRecords")]
    public interface IServiceDiscoveryServiceDnsConfigDnsRecords
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#ttl ServiceDiscoveryService#ttl}.</summary>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        double Ttl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#type ServiceDiscoveryService#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceDiscoveryServiceDnsConfigDnsRecords), fullyQualifiedName: "aws.serviceDiscoveryService.ServiceDiscoveryServiceDnsConfigDnsRecords")]
        internal sealed class _Proxy : DeputyBase, aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfigDnsRecords
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#ttl ServiceDiscoveryService#ttl}.</summary>
            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
            public double Ttl
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#type ServiceDiscoveryService#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
