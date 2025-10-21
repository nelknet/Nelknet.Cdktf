using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchOutboundConnection
{
    [JsiiInterface(nativeType: typeof(IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch), fullyQualifiedName: "aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch")]
    public interface IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#skip_unavailable OpensearchOutboundConnection#skip_unavailable}.</summary>
        [JsiiProperty(name: "skipUnavailable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SkipUnavailable
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch), fullyQualifiedName: "aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#skip_unavailable OpensearchOutboundConnection#skip_unavailable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skipUnavailable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SkipUnavailable
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
