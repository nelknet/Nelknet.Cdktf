using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewriteHostname")]
    public class AppmeshGatewayRouteSpecHttpRouteActionRewriteHostname : aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewriteHostname
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#default_target_hostname AppmeshGatewayRoute#default_target_hostname}.</summary>
        [JsiiProperty(name: "defaultTargetHostname", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultTargetHostname
        {
            get;
            set;
        }
    }
}
