using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomain
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainClusterConfigZoneAwarenessConfig), fullyQualifiedName: "aws.elasticsearchDomain.ElasticsearchDomainClusterConfigZoneAwarenessConfig")]
    public interface IElasticsearchDomainClusterConfigZoneAwarenessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#availability_zone_count ElasticsearchDomain#availability_zone_count}.</summary>
        [JsiiProperty(name: "availabilityZoneCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AvailabilityZoneCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainClusterConfigZoneAwarenessConfig), fullyQualifiedName: "aws.elasticsearchDomain.ElasticsearchDomainClusterConfigZoneAwarenessConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ElasticsearchDomain.IElasticsearchDomainClusterConfigZoneAwarenessConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#availability_zone_count ElasticsearchDomain#availability_zone_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZoneCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AvailabilityZoneCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
