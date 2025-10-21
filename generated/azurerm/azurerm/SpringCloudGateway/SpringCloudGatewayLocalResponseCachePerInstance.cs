using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudGateway
{
    [JsiiByValue(fqn: "azurerm.springCloudGateway.SpringCloudGatewayLocalResponseCachePerInstance")]
    public class SpringCloudGatewayLocalResponseCachePerInstance : azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerInstance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#size SpringCloudGateway#size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Size
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#time_to_live SpringCloudGateway#time_to_live}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeToLive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeToLive
        {
            get;
            set;
        }
    }
}
