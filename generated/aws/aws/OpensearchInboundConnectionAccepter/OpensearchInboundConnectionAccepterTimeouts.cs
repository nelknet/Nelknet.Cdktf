using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchInboundConnectionAccepter
{
    [JsiiByValue(fqn: "aws.opensearchInboundConnectionAccepter.OpensearchInboundConnectionAccepterTimeouts")]
    public class OpensearchInboundConnectionAccepterTimeouts : aws.OpensearchInboundConnectionAccepter.IOpensearchInboundConnectionAccepterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_inbound_connection_accepter#create OpensearchInboundConnectionAccepter#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_inbound_connection_accepter#delete OpensearchInboundConnectionAccepter#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
