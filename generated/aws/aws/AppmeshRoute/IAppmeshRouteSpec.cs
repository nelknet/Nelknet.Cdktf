using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpec), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpec")]
    public interface IAppmeshRouteSpec
    {
        /// <summary>grpc_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#grpc_route AppmeshRoute#grpc_route}
        /// </remarks>
        [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecGrpcRoute? GrpcRoute
        {
            get
            {
                return null;
            }
        }

        /// <summary>http2_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#http2_route AppmeshRoute#http2_route}
        /// </remarks>
        [JsiiProperty(name: "http2Route", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2Route\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecHttp2Route? Http2Route
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#http_route AppmeshRoute#http_route}
        /// </remarks>
        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecHttpRoute? HttpRoute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#priority AppmeshRoute#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>tcp_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#tcp_route AppmeshRoute#tcp_route}
        /// </remarks>
        [JsiiProperty(name: "tcpRoute", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecTcpRoute? TcpRoute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpec), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpec")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshRoute.IAppmeshRouteSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grpc_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#grpc_route AppmeshRoute#grpc_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRoute\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecGrpcRoute? GrpcRoute
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecGrpcRoute?>();
            }

            /// <summary>http2_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#http2_route AppmeshRoute#http2_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2Route", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2Route\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecHttp2Route? Http2Route
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttp2Route?>();
            }

            /// <summary>http_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#http_route AppmeshRoute#http_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRoute\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecHttpRoute? HttpRoute
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRoute?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#priority AppmeshRoute#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>tcp_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#tcp_route AppmeshRoute#tcp_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcpRoute", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRoute\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecTcpRoute? TcpRoute
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecTcpRoute?>();
            }
        }
    }
}
