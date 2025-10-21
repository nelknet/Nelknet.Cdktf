using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    [JsiiByValue(fqn: "azurerm.springCloudService.SpringCloudServiceDefaultBuildService")]
    public class SpringCloudServiceDefaultBuildService : azurerm.SpringCloudService.ISpringCloudServiceDefaultBuildService
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#container_registry_name SpringCloudService#container_registry_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerRegistryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerRegistryName
        {
            get;
            set;
        }
    }
}
