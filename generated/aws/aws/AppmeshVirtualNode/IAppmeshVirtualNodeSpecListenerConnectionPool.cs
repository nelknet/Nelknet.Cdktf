using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerConnectionPool), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPool")]
    public interface IAppmeshVirtualNodeSpecListenerConnectionPool
    {
        /// <summary>grpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#grpc AppmeshVirtualNode#grpc}
        /// </remarks>
        [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolGrpc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc? Grpc
        {
            get
            {
                return null;
            }
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#http AppmeshVirtualNode#http}
        /// </remarks>
        [JsiiProperty(name: "http", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolHttp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Http
        {
            get
            {
                return null;
            }
        }

        /// <summary>http2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#http2 AppmeshVirtualNode#http2}
        /// </remarks>
        [JsiiProperty(name: "http2", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolHttp2\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Http2
        {
            get
            {
                return null;
            }
        }

        /// <summary>tcp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#tcp AppmeshVirtualNode#tcp}
        /// </remarks>
        [JsiiProperty(name: "tcp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolTcp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tcp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerConnectionPool), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPool")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerConnectionPool
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grpc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#grpc AppmeshVirtualNode#grpc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolGrpc\"}", isOptional: true)]
            public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc? Grpc
            {
                get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc?>();
            }

            /// <summary>http block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#http AppmeshVirtualNode#http}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolHttp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Http
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#http2 AppmeshVirtualNode#http2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolHttp2\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Http2
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tcp block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#tcp AppmeshVirtualNode#tcp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolTcp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tcp
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
