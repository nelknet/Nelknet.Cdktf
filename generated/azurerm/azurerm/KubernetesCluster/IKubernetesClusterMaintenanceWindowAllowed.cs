using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterMaintenanceWindowAllowed), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAllowed")]
    public interface IKubernetesClusterMaintenanceWindowAllowed
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#day KubernetesCluster#day}.</summary>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
        string Day
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#hours KubernetesCluster#hours}.</summary>
        [JsiiProperty(name: "hours", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        double[] Hours
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterMaintenanceWindowAllowed), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAllowed")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAllowed
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#day KubernetesCluster#day}.</summary>
            [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
            public string Day
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#hours KubernetesCluster#hours}.</summary>
            [JsiiProperty(name: "hours", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
            public double[] Hours
            {
                get => GetInstanceProperty<double[]>()!;
            }
        }
    }
}
