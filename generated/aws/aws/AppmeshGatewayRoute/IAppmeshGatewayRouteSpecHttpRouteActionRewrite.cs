using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecHttpRouteActionRewrite), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewrite")]
    public interface IAppmeshGatewayRouteSpecHttpRouteActionRewrite
    {
        /// <summary>hostname block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#hostname AppmeshGatewayRoute#hostname}
        /// </remarks>
        [JsiiProperty(name: "hostname", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewriteHostname\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewriteHostname? Hostname
        {
            get
            {
                return null;
            }
        }

        /// <summary>path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#path AppmeshGatewayRoute#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePath\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePath? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>prefix block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#prefix AppmeshGatewayRoute#prefix}
        /// </remarks>
        [JsiiProperty(name: "prefix", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePrefix\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePrefix? Prefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecHttpRouteActionRewrite), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewrite")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewrite
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>hostname block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#hostname AppmeshGatewayRoute#hostname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostname", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewriteHostname\"}", isOptional: true)]
            public aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewriteHostname? Hostname
            {
                get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewriteHostname?>();
            }

            /// <summary>path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#path AppmeshGatewayRoute#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePath\"}", isOptional: true)]
            public aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePath? Path
            {
                get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePath?>();
            }

            /// <summary>prefix block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#prefix AppmeshGatewayRoute#prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePrefix\"}", isOptional: true)]
            public aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePrefix? Prefix
            {
                get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePrefix?>();
            }
        }
    }
}
