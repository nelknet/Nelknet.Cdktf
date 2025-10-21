using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudGatewayRouteConfig
{
    [JsiiInterface(nativeType: typeof(ISpringCloudGatewayRouteConfigOpenApi), fullyQualifiedName: "azurerm.springCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigOpenApi")]
    public interface ISpringCloudGatewayRouteConfigOpenApi
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#uri SpringCloudGatewayRouteConfig#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudGatewayRouteConfigOpenApi), fullyQualifiedName: "azurerm.springCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigOpenApi")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigOpenApi
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#uri SpringCloudGatewayRouteConfig#uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
