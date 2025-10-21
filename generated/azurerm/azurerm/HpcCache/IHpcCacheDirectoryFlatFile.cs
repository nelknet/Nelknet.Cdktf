using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCache
{
    [JsiiInterface(nativeType: typeof(IHpcCacheDirectoryFlatFile), fullyQualifiedName: "azurerm.hpcCache.HpcCacheDirectoryFlatFile")]
    public interface IHpcCacheDirectoryFlatFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#group_file_uri HpcCache#group_file_uri}.</summary>
        [JsiiProperty(name: "groupFileUri", typeJson: "{\"primitive\":\"string\"}")]
        string GroupFileUri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#password_file_uri HpcCache#password_file_uri}.</summary>
        [JsiiProperty(name: "passwordFileUri", typeJson: "{\"primitive\":\"string\"}")]
        string PasswordFileUri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHpcCacheDirectoryFlatFile), fullyQualifiedName: "azurerm.hpcCache.HpcCacheDirectoryFlatFile")]
        internal sealed class _Proxy : DeputyBase, azurerm.HpcCache.IHpcCacheDirectoryFlatFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#group_file_uri HpcCache#group_file_uri}.</summary>
            [JsiiProperty(name: "groupFileUri", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupFileUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#password_file_uri HpcCache#password_file_uri}.</summary>
            [JsiiProperty(name: "passwordFileUri", typeJson: "{\"primitive\":\"string\"}")]
            public string PasswordFileUri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
