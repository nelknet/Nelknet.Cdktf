using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiByValue(fqn: "aws.opensearchDomain.OpensearchDomainClusterConfigNodeOptions")]
    public class OpensearchDomainClusterConfigNodeOptions : aws.OpensearchDomain.IOpensearchDomainClusterConfigNodeOptions
    {
        /// <summary>node_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#node_config OpensearchDomain#node_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeConfig", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigNodeOptionsNodeConfig\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainClusterConfigNodeOptionsNodeConfig? NodeConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#node_type OpensearchDomain#node_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeType
        {
            get;
            set;
        }
    }
}
