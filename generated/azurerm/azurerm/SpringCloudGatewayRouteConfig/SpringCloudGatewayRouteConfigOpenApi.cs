using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudGatewayRouteConfig
{
    [JsiiByValue(fqn: "azurerm.springCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigOpenApi")]
    public class SpringCloudGatewayRouteConfigOpenApi : azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigOpenApi
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#uri SpringCloudGatewayRouteConfig#uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uri
        {
            get;
            set;
        }
    }
}
