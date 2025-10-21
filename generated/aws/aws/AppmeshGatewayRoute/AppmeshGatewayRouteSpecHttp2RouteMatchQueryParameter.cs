using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteMatchQueryParameter")]
    public class AppmeshGatewayRouteSpecHttp2RouteMatchQueryParameter : aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteMatchQueryParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#name AppmeshGatewayRoute#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#match AppmeshGatewayRoute#match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteMatchQueryParameterMatch\"}", isOptional: true)]
        public aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteMatchQueryParameterMatch? Match
        {
            get;
            set;
        }
    }
}
