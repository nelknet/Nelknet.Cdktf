using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterLinuxProfileSshKey), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterLinuxProfileSshKey")]
    public interface IKubernetesClusterLinuxProfileSshKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_data KubernetesCluster#key_data}.</summary>
        [JsiiProperty(name: "keyData", typeJson: "{\"primitive\":\"string\"}")]
        string KeyData
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterLinuxProfileSshKey), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterLinuxProfileSshKey")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterLinuxProfileSshKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_data KubernetesCluster#key_data}.</summary>
            [JsiiProperty(name: "keyData", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyData
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
