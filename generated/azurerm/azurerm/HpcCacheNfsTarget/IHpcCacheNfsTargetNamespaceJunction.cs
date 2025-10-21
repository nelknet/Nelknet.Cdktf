using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCacheNfsTarget
{
    [JsiiInterface(nativeType: typeof(IHpcCacheNfsTargetNamespaceJunction), fullyQualifiedName: "azurerm.hpcCacheNfsTarget.HpcCacheNfsTargetNamespaceJunction")]
    public interface IHpcCacheNfsTargetNamespaceJunction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#namespace_path HpcCacheNfsTarget#namespace_path}.</summary>
        [JsiiProperty(name: "namespacePath", typeJson: "{\"primitive\":\"string\"}")]
        string NamespacePath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#nfs_export HpcCacheNfsTarget#nfs_export}.</summary>
        [JsiiProperty(name: "nfsExport", typeJson: "{\"primitive\":\"string\"}")]
        string NfsExport
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#access_policy_name HpcCacheNfsTarget#access_policy_name}.</summary>
        [JsiiProperty(name: "accessPolicyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessPolicyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#target_path HpcCacheNfsTarget#target_path}.</summary>
        [JsiiProperty(name: "targetPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHpcCacheNfsTargetNamespaceJunction), fullyQualifiedName: "azurerm.hpcCacheNfsTarget.HpcCacheNfsTargetNamespaceJunction")]
        internal sealed class _Proxy : DeputyBase, azurerm.HpcCacheNfsTarget.IHpcCacheNfsTargetNamespaceJunction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#namespace_path HpcCacheNfsTarget#namespace_path}.</summary>
            [JsiiProperty(name: "namespacePath", typeJson: "{\"primitive\":\"string\"}")]
            public string NamespacePath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#nfs_export HpcCacheNfsTarget#nfs_export}.</summary>
            [JsiiProperty(name: "nfsExport", typeJson: "{\"primitive\":\"string\"}")]
            public string NfsExport
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#access_policy_name HpcCacheNfsTarget#access_policy_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessPolicyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessPolicyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#target_path HpcCacheNfsTarget#target_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
