using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCacheNfsTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hpcCacheNfsTarget.HpcCacheNfsTargetNamespaceJunction")]
    public class HpcCacheNfsTargetNamespaceJunction : azurerm.HpcCacheNfsTarget.IHpcCacheNfsTargetNamespaceJunction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#namespace_path HpcCacheNfsTarget#namespace_path}.</summary>
        [JsiiProperty(name: "namespacePath", typeJson: "{\"primitive\":\"string\"}")]
        public string NamespacePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#nfs_export HpcCacheNfsTarget#nfs_export}.</summary>
        [JsiiProperty(name: "nfsExport", typeJson: "{\"primitive\":\"string\"}")]
        public string NfsExport
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#access_policy_name HpcCacheNfsTarget#access_policy_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessPolicyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessPolicyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#target_path HpcCacheNfsTarget#target_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetPath
        {
            get;
            set;
        }
    }
}
