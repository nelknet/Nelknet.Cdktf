using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupPolicyKubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IDataProtectionBackupPolicyKubernetesClusterDefaultRetentionRuleLifeCycle), fullyQualifiedName: "azurerm.dataProtectionBackupPolicyKubernetesCluster.DataProtectionBackupPolicyKubernetesClusterDefaultRetentionRuleLifeCycle")]
    public interface IDataProtectionBackupPolicyKubernetesClusterDefaultRetentionRuleLifeCycle
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_kubernetes_cluster#data_store_type DataProtectionBackupPolicyKubernetesCluster#data_store_type}.</summary>
        [JsiiProperty(name: "dataStoreType", typeJson: "{\"primitive\":\"string\"}")]
        string DataStoreType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_kubernetes_cluster#duration DataProtectionBackupPolicyKubernetesCluster#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        string Duration
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataProtectionBackupPolicyKubernetesClusterDefaultRetentionRuleLifeCycle), fullyQualifiedName: "azurerm.dataProtectionBackupPolicyKubernetesCluster.DataProtectionBackupPolicyKubernetesClusterDefaultRetentionRuleLifeCycle")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataProtectionBackupPolicyKubernetesCluster.IDataProtectionBackupPolicyKubernetesClusterDefaultRetentionRuleLifeCycle
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_kubernetes_cluster#data_store_type DataProtectionBackupPolicyKubernetesCluster#data_store_type}.</summary>
            [JsiiProperty(name: "dataStoreType", typeJson: "{\"primitive\":\"string\"}")]
            public string DataStoreType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_kubernetes_cluster#duration DataProtectionBackupPolicyKubernetesCluster#duration}.</summary>
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
            public string Duration
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
