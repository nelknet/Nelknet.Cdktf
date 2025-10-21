using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiByValue(fqn: "aws.appmeshRoute.AppmeshRouteSpec")]
    public class AppmeshRouteSpec : aws.AppmeshRoute.IAppmeshRouteSpec
    {
        /// <summary>grpc_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#grpc_route AppmeshRoute#grpc_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRoute\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecGrpcRoute? GrpcRoute
        {
            get;
            set;
        }

        /// <summary>http2_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#http2_route AppmeshRoute#http2_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http2Route", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2Route\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecHttp2Route? Http2Route
        {
            get;
            set;
        }

        /// <summary>http_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#http_route AppmeshRoute#http_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRoute\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecHttpRoute? HttpRoute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#priority AppmeshRoute#priority}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>tcp_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#tcp_route AppmeshRoute#tcp_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpRoute", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRoute\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecTcpRoute? TcpRoute
        {
            get;
            set;
        }
    }
}
