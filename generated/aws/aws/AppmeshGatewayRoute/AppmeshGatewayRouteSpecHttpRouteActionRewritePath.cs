using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePath")]
    public class AppmeshGatewayRouteSpecHttpRouteActionRewritePath : aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePath
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#exact AppmeshGatewayRoute#exact}.</summary>
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}")]
        public string Exact
        {
            get;
            set;
        }
    }
}
