using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiByValue(fqn: "aws.opensearchDomain.OpensearchDomainClusterConfigZoneAwarenessConfig")]
    public class OpensearchDomainClusterConfigZoneAwarenessConfig : aws.OpensearchDomain.IOpensearchDomainClusterConfigZoneAwarenessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#availability_zone_count OpensearchDomain#availability_zone_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AvailabilityZoneCount
        {
            get;
            set;
        }
    }
}
