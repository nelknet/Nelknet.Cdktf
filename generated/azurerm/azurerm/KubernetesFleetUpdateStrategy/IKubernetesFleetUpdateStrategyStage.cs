using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFleetUpdateStrategy
{
    [JsiiInterface(nativeType: typeof(IKubernetesFleetUpdateStrategyStage), fullyQualifiedName: "azurerm.kubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategyStage")]
    public interface IKubernetesFleetUpdateStrategyStage
    {
        /// <summary>group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy#group KubernetesFleetUpdateStrategy#group}
        /// </remarks>
        [JsiiProperty(name: "group", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategyStageGroup\"},\"kind\":\"array\"}}]}}")]
        object Group
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy#name KubernetesFleetUpdateStrategy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy#after_stage_wait_in_seconds KubernetesFleetUpdateStrategy#after_stage_wait_in_seconds}.</summary>
        [JsiiProperty(name: "afterStageWaitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AfterStageWaitInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesFleetUpdateStrategyStage), fullyQualifiedName: "azurerm.kubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategyStage")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesFleetUpdateStrategy.IKubernetesFleetUpdateStrategyStage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy#group KubernetesFleetUpdateStrategy#group}
            /// </remarks>
            [JsiiProperty(name: "group", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategyStageGroup\"},\"kind\":\"array\"}}]}}")]
            public object Group
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy#name KubernetesFleetUpdateStrategy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy#after_stage_wait_in_seconds KubernetesFleetUpdateStrategy#after_stage_wait_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "afterStageWaitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AfterStageWaitInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
