using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    [JsiiInterface(nativeType: typeof(ISpringCloudServiceDefaultBuildService), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceDefaultBuildService")]
    public interface ISpringCloudServiceDefaultBuildService
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#container_registry_name SpringCloudService#container_registry_name}.</summary>
        [JsiiProperty(name: "containerRegistryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainerRegistryName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudServiceDefaultBuildService), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceDefaultBuildService")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudService.ISpringCloudServiceDefaultBuildService
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#container_registry_name SpringCloudService#container_registry_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerRegistryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerRegistryName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
