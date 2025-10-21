using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchOutboundConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opensearchOutboundConnection.OpensearchOutboundConnectionLocalDomainInfo")]
    public class OpensearchOutboundConnectionLocalDomainInfo : aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionLocalDomainInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#domain_name OpensearchOutboundConnection#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#owner_id OpensearchOutboundConnection#owner_id}.</summary>
        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}")]
        public string OwnerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#region OpensearchOutboundConnection#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }
    }
}
