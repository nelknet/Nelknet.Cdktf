using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainClusterConfigNodeOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainClusterConfigNodeOptions")]
    public interface IOpensearchDomainClusterConfigNodeOptions
    {
        /// <summary>node_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#node_config OpensearchDomain#node_config}
        /// </remarks>
        [JsiiProperty(name: "nodeConfig", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigNodeOptionsNodeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainClusterConfigNodeOptionsNodeConfig? NodeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#node_type OpensearchDomain#node_type}.</summary>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainClusterConfigNodeOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainClusterConfigNodeOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainClusterConfigNodeOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>node_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#node_config OpensearchDomain#node_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeConfig", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigNodeOptionsNodeConfig\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainClusterConfigNodeOptionsNodeConfig? NodeConfig
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainClusterConfigNodeOptionsNodeConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#node_type OpensearchDomain#node_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
