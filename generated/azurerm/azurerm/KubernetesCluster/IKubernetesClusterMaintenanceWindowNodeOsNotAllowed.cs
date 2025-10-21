using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterMaintenanceWindowNodeOsNotAllowed), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNodeOsNotAllowed")]
    public interface IKubernetesClusterMaintenanceWindowNodeOsNotAllowed
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#end KubernetesCluster#end}.</summary>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}")]
        string End
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#start KubernetesCluster#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
        string Start
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterMaintenanceWindowNodeOsNotAllowed), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNodeOsNotAllowed")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNodeOsNotAllowed
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#end KubernetesCluster#end}.</summary>
            [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}")]
            public string End
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#start KubernetesCluster#start}.</summary>
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
            public string Start
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
