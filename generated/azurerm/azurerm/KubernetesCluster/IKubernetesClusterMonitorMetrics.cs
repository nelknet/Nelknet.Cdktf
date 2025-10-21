using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterMonitorMetrics), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterMonitorMetrics")]
    public interface IKubernetesClusterMonitorMetrics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#annotations_allowed KubernetesCluster#annotations_allowed}.</summary>
        [JsiiProperty(name: "annotationsAllowed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AnnotationsAllowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#labels_allowed KubernetesCluster#labels_allowed}.</summary>
        [JsiiProperty(name: "labelsAllowed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LabelsAllowed
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterMonitorMetrics), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterMonitorMetrics")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterMonitorMetrics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#annotations_allowed KubernetesCluster#annotations_allowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "annotationsAllowed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AnnotationsAllowed
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#labels_allowed KubernetesCluster#labels_allowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "labelsAllowed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LabelsAllowed
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
