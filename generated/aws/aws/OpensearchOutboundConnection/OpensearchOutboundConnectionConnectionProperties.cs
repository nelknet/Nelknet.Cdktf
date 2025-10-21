using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchOutboundConnection
{
    [JsiiByValue(fqn: "aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionProperties")]
    public class OpensearchOutboundConnectionConnectionProperties : aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionProperties
    {
        /// <summary>cross_cluster_search block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#cross_cluster_search OpensearchOutboundConnection#cross_cluster_search}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "crossClusterSearch", typeJson: "{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch\"}", isOptional: true)]
        public aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch? CrossClusterSearch
        {
            get;
            set;
        }
    }
}
