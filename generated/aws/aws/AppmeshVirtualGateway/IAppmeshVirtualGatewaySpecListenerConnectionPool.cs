using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualGateway
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecListenerConnectionPool), fullyQualifiedName: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPool")]
    public interface IAppmeshVirtualGatewaySpecListenerConnectionPool
    {
        /// <summary>grpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#grpc AppmeshVirtualGateway#grpc}
        /// </remarks>
        [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc? Grpc
        {
            get
            {
                return null;
            }
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#http AppmeshVirtualGateway#http}
        /// </remarks>
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp? Http
        {
            get
            {
                return null;
            }
        }

        /// <summary>http2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#http2 AppmeshVirtualGateway#http2}
        /// </remarks>
        [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2? Http2
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecListenerConnectionPool), fullyQualifiedName: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPool")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPool
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grpc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#grpc AppmeshVirtualGateway#grpc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpc\"}", isOptional: true)]
            public aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc? Grpc
            {
                get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc?>();
            }

            /// <summary>http block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#http AppmeshVirtualGateway#http}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp\"}", isOptional: true)]
            public aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp? Http
            {
                get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp?>();
            }

            /// <summary>http2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#http2 AppmeshVirtualGateway#http2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2\"}", isOptional: true)]
            public aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2? Http2
            {
                get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2?>();
            }
        }
    }
}
