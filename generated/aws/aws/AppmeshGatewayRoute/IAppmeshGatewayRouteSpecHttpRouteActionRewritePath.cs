using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecHttpRouteActionRewritePath), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePath")]
    public interface IAppmeshGatewayRouteSpecHttpRouteActionRewritePath
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#exact AppmeshGatewayRoute#exact}.</summary>
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}")]
        string Exact
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecHttpRouteActionRewritePath), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePath")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePath
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#exact AppmeshGatewayRoute#exact}.</summary>
            [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}")]
            public string Exact
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
