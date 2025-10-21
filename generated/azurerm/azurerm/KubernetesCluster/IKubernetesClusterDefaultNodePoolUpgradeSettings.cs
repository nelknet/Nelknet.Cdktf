using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterDefaultNodePoolUpgradeSettings), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolUpgradeSettings")]
    public interface IKubernetesClusterDefaultNodePoolUpgradeSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_surge KubernetesCluster#max_surge}.</summary>
        [JsiiProperty(name: "maxSurge", typeJson: "{\"primitive\":\"string\"}")]
        string MaxSurge
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#drain_timeout_in_minutes KubernetesCluster#drain_timeout_in_minutes}.</summary>
        [JsiiProperty(name: "drainTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DrainTimeoutInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_soak_duration_in_minutes KubernetesCluster#node_soak_duration_in_minutes}.</summary>
        [JsiiProperty(name: "nodeSoakDurationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NodeSoakDurationInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterDefaultNodePoolUpgradeSettings), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolUpgradeSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolUpgradeSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_surge KubernetesCluster#max_surge}.</summary>
            [JsiiProperty(name: "maxSurge", typeJson: "{\"primitive\":\"string\"}")]
            public string MaxSurge
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#drain_timeout_in_minutes KubernetesCluster#drain_timeout_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "drainTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DrainTimeoutInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_soak_duration_in_minutes KubernetesCluster#node_soak_duration_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeSoakDurationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NodeSoakDurationInMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
