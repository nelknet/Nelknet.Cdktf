using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecHttp2RouteAction), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteAction")]
    public interface IAppmeshGatewayRouteSpecHttp2RouteAction
    {
        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#target AppmeshGatewayRoute#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTarget\"}")]
        aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionTarget Target
        {
            get;
        }

        /// <summary>rewrite block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#rewrite AppmeshGatewayRoute#rewrite}
        /// </remarks>
        [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionRewrite\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionRewrite? Rewrite
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecHttp2RouteAction), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteAction")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#target AppmeshGatewayRoute#target}
            /// </remarks>
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTarget\"}")]
            public aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionTarget Target
            {
                get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionTarget>()!;
            }

            /// <summary>rewrite block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#rewrite AppmeshGatewayRoute#rewrite}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionRewrite\"}", isOptional: true)]
            public aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionRewrite? Rewrite
            {
                get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionRewrite?>();
            }
        }
    }
}
