using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchInboundConnectionAccepter
{
    [JsiiInterface(nativeType: typeof(IOpensearchInboundConnectionAccepterTimeouts), fullyQualifiedName: "aws.opensearchInboundConnectionAccepter.OpensearchInboundConnectionAccepterTimeouts")]
    public interface IOpensearchInboundConnectionAccepterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_inbound_connection_accepter#create OpensearchInboundConnectionAccepter#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_inbound_connection_accepter#delete OpensearchInboundConnectionAccepter#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchInboundConnectionAccepterTimeouts), fullyQualifiedName: "aws.opensearchInboundConnectionAccepter.OpensearchInboundConnectionAccepterTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchInboundConnectionAccepter.IOpensearchInboundConnectionAccepterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_inbound_connection_accepter#create OpensearchInboundConnectionAccepter#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_inbound_connection_accepter#delete OpensearchInboundConnectionAccepter#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
