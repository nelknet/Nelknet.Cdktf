using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterKeyManagementService")]
    public class KubernetesClusterKeyManagementService : azurerm.KubernetesCluster.IKubernetesClusterKeyManagementService
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_vault_key_id KubernetesCluster#key_vault_key_id}.</summary>
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_vault_network_access KubernetesCluster#key_vault_network_access}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyVaultNetworkAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyVaultNetworkAccess
        {
            get;
            set;
        }
    }
}
