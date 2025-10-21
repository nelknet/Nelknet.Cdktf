using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTask
{
    [JsiiInterface(nativeType: typeof(IContainerRegistryTaskRegistryCredentialSource), fullyQualifiedName: "azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialSource")]
    public interface IContainerRegistryTaskRegistryCredentialSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#login_mode ContainerRegistryTask#login_mode}.</summary>
        [JsiiProperty(name: "loginMode", typeJson: "{\"primitive\":\"string\"}")]
        string LoginMode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerRegistryTaskRegistryCredentialSource), fullyQualifiedName: "azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialSource")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#login_mode ContainerRegistryTask#login_mode}.</summary>
            [JsiiProperty(name: "loginMode", typeJson: "{\"primitive\":\"string\"}")]
            public string LoginMode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
