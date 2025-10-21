using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainClusterConfigZoneAwarenessConfig), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainClusterConfigZoneAwarenessConfig")]
    public interface IOpensearchDomainClusterConfigZoneAwarenessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#availability_zone_count OpensearchDomain#availability_zone_count}.</summary>
        [JsiiProperty(name: "availabilityZoneCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AvailabilityZoneCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainClusterConfigZoneAwarenessConfig), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainClusterConfigZoneAwarenessConfig")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainClusterConfigZoneAwarenessConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#availability_zone_count OpensearchDomain#availability_zone_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZoneCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AvailabilityZoneCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
