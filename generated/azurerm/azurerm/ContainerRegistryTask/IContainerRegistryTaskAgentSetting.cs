using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTask
{
    [JsiiInterface(nativeType: typeof(IContainerRegistryTaskAgentSetting), fullyQualifiedName: "azurerm.containerRegistryTask.ContainerRegistryTaskAgentSetting")]
    public interface IContainerRegistryTaskAgentSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#cpu ContainerRegistryTask#cpu}.</summary>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
        double Cpu
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerRegistryTaskAgentSetting), fullyQualifiedName: "azurerm.containerRegistryTask.ContainerRegistryTaskAgentSetting")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerRegistryTask.IContainerRegistryTaskAgentSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#cpu ContainerRegistryTask#cpu}.</summary>
            [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
            public double Cpu
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
