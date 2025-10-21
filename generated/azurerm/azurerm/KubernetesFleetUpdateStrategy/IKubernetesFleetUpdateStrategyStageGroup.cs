using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFleetUpdateStrategy
{
    [JsiiInterface(nativeType: typeof(IKubernetesFleetUpdateStrategyStageGroup), fullyQualifiedName: "azurerm.kubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategyStageGroup")]
    public interface IKubernetesFleetUpdateStrategyStageGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy#name KubernetesFleetUpdateStrategy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesFleetUpdateStrategyStageGroup), fullyQualifiedName: "azurerm.kubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategyStageGroup")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesFleetUpdateStrategy.IKubernetesFleetUpdateStrategyStageGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy#name KubernetesFleetUpdateStrategy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
