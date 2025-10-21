using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterWorkloadAutoscalerProfile), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterWorkloadAutoscalerProfile")]
    public interface IKubernetesClusterWorkloadAutoscalerProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#keda_enabled KubernetesCluster#keda_enabled}.</summary>
        [JsiiProperty(name: "kedaEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KedaEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#vertical_pod_autoscaler_enabled KubernetesCluster#vertical_pod_autoscaler_enabled}.</summary>
        [JsiiProperty(name: "verticalPodAutoscalerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VerticalPodAutoscalerEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterWorkloadAutoscalerProfile), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterWorkloadAutoscalerProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterWorkloadAutoscalerProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#keda_enabled KubernetesCluster#keda_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kedaEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? KedaEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#vertical_pod_autoscaler_enabled KubernetesCluster#vertical_pod_autoscaler_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verticalPodAutoscalerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? VerticalPodAutoscalerEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
