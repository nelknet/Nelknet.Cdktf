using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ServiceDiscoveryService
{
    [JsiiInterface(nativeType: typeof(IServiceDiscoveryServiceHealthCheckCustomConfig), fullyQualifiedName: "aws.serviceDiscoveryService.ServiceDiscoveryServiceHealthCheckCustomConfig")]
    public interface IServiceDiscoveryServiceHealthCheckCustomConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#failure_threshold ServiceDiscoveryService#failure_threshold}.</summary>
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FailureThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceDiscoveryServiceHealthCheckCustomConfig), fullyQualifiedName: "aws.serviceDiscoveryService.ServiceDiscoveryServiceHealthCheckCustomConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ServiceDiscoveryService.IServiceDiscoveryServiceHealthCheckCustomConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#failure_threshold ServiceDiscoveryService#failure_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailureThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
