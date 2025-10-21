using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ServiceDiscoveryService
{
    [JsiiByValue(fqn: "aws.serviceDiscoveryService.ServiceDiscoveryServiceHealthCheckCustomConfig")]
    public class ServiceDiscoveryServiceHealthCheckCustomConfig : aws.ServiceDiscoveryService.IServiceDiscoveryServiceHealthCheckCustomConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#failure_threshold ServiceDiscoveryService#failure_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureThreshold
        {
            get;
            set;
        }
    }
}
