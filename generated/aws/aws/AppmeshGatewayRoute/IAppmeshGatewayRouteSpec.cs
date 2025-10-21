using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpec), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpec")]
    public interface IAppmeshGatewayRouteSpec
    {
        /// <summary>grpc_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#grpc_route AppmeshGatewayRoute#grpc_route}
        /// </remarks>
        [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRoute? GrpcRoute
        {
            get
            {
                return null;
            }
        }

        /// <summary>http2_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#http2_route AppmeshGatewayRoute#http2_route}
        /// </remarks>
        [JsiiProperty(name: "http2Route", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2Route\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2Route? Http2Route
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#http_route AppmeshGatewayRoute#http_route}
        /// </remarks>
        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRoute? HttpRoute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#priority AppmeshGatewayRoute#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpec), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpec")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grpc_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#grpc_route AppmeshGatewayRoute#grpc_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRoute\"}", isOptional: true)]
            public aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRoute? GrpcRoute
            {
                get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRoute?>();
            }

            /// <summary>http2_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#http2_route AppmeshGatewayRoute#http2_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2Route", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2Route\"}", isOptional: true)]
            public aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2Route? Http2Route
            {
                get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2Route?>();
            }

            /// <summary>http_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#http_route AppmeshGatewayRoute#http_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRoute\"}", isOptional: true)]
            public aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRoute? HttpRoute
            {
                get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRoute?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#priority AppmeshGatewayRoute#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
