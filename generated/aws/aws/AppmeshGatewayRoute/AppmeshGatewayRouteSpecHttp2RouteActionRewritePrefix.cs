using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    [JsiiByValue(fqn: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionRewritePrefix")]
    public class AppmeshGatewayRouteSpecHttp2RouteActionRewritePrefix : aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionRewritePrefix
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#default_prefix AppmeshGatewayRoute#default_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#value AppmeshGatewayRoute#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
