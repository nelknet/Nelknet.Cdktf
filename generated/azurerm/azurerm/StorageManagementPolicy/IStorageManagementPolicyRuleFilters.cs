using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IStorageManagementPolicyRuleFilters), fullyQualifiedName: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleFilters")]
    public interface IStorageManagementPolicyRuleFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#blob_types StorageManagementPolicy#blob_types}.</summary>
        [JsiiProperty(name: "blobTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] BlobTypes
        {
            get;
        }

        /// <summary>match_blob_index_tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#match_blob_index_tag StorageManagementPolicy#match_blob_index_tag}
        /// </remarks>
        [JsiiProperty(name: "matchBlobIndexTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleFiltersMatchBlobIndexTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MatchBlobIndexTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#prefix_match StorageManagementPolicy#prefix_match}.</summary>
        [JsiiProperty(name: "prefixMatch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PrefixMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageManagementPolicyRuleFilters), fullyQualifiedName: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleFilters")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#blob_types StorageManagementPolicy#blob_types}.</summary>
            [JsiiProperty(name: "blobTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] BlobTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>match_blob_index_tag block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#match_blob_index_tag StorageManagementPolicy#match_blob_index_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchBlobIndexTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleFiltersMatchBlobIndexTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MatchBlobIndexTag
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#prefix_match StorageManagementPolicy#prefix_match}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefixMatch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PrefixMatch
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
