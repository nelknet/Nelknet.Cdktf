using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchOutboundConnection
{
    [JsiiInterface(nativeType: typeof(IOpensearchOutboundConnectionConnectionProperties), fullyQualifiedName: "aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionProperties")]
    public interface IOpensearchOutboundConnectionConnectionProperties
    {
        /// <summary>cross_cluster_search block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#cross_cluster_search OpensearchOutboundConnection#cross_cluster_search}
        /// </remarks>
        [JsiiProperty(name: "crossClusterSearch", typeJson: "{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch? CrossClusterSearch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchOutboundConnectionConnectionProperties), fullyQualifiedName: "aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionProperties")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cross_cluster_search block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#cross_cluster_search OpensearchOutboundConnection#cross_cluster_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crossClusterSearch", typeJson: "{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch\"}", isOptional: true)]
            public aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch? CrossClusterSearch
            {
                get => GetInstanceProperty<aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch?>();
            }
        }
    }
}
