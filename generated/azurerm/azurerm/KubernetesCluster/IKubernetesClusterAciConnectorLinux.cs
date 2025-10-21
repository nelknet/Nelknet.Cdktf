using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterAciConnectorLinux), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterAciConnectorLinux")]
    public interface IKubernetesClusterAciConnectorLinux
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#subnet_name KubernetesCluster#subnet_name}.</summary>
        [JsiiProperty(name: "subnetName", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterAciConnectorLinux), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterAciConnectorLinux")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterAciConnectorLinux
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#subnet_name KubernetesCluster#subnet_name}.</summary>
            [JsiiProperty(name: "subnetName", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
