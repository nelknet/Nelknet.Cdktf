using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterKeyManagementService), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterKeyManagementService")]
    public interface IKubernetesClusterKeyManagementService
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_vault_key_id KubernetesCluster#key_vault_key_id}.</summary>
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultKeyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_vault_network_access KubernetesCluster#key_vault_network_access}.</summary>
        [JsiiProperty(name: "keyVaultNetworkAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyVaultNetworkAccess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterKeyManagementService), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterKeyManagementService")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterKeyManagementService
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_vault_key_id KubernetesCluster#key_vault_key_id}.</summary>
            [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultKeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_vault_network_access KubernetesCluster#key_vault_network_access}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyVaultNetworkAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyVaultNetworkAccess
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
