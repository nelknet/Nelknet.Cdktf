using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchOutboundConnection
{
    [JsiiByValue(fqn: "aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch")]
    public class OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch : aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#skip_unavailable OpensearchOutboundConnection#skip_unavailable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skipUnavailable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SkipUnavailable
        {
            get;
            set;
        }
    }
}
