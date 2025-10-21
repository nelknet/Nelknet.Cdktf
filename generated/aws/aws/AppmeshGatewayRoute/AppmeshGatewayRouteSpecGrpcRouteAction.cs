using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRouteAction")]
    public class AppmeshGatewayRouteSpecGrpcRouteAction : aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRouteAction
    {
        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#target AppmeshGatewayRoute#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRouteActionTarget\"}")]
        public aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRouteActionTarget Target
        {
            get;
            set;
        }
    }
}
