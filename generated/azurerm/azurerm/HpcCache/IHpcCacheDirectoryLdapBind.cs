using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCache
{
    [JsiiInterface(nativeType: typeof(IHpcCacheDirectoryLdapBind), fullyQualifiedName: "azurerm.hpcCache.HpcCacheDirectoryLdapBind")]
    public interface IHpcCacheDirectoryLdapBind
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#dn HpcCache#dn}.</summary>
        [JsiiProperty(name: "dn", typeJson: "{\"primitive\":\"string\"}")]
        string Dn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#password HpcCache#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHpcCacheDirectoryLdapBind), fullyQualifiedName: "azurerm.hpcCache.HpcCacheDirectoryLdapBind")]
        internal sealed class _Proxy : DeputyBase, azurerm.HpcCache.IHpcCacheDirectoryLdapBind
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#dn HpcCache#dn}.</summary>
            [JsiiProperty(name: "dn", typeJson: "{\"primitive\":\"string\"}")]
            public string Dn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#password HpcCache#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
