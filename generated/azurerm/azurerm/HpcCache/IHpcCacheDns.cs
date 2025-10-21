using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCache
{
    [JsiiInterface(nativeType: typeof(IHpcCacheDns), fullyQualifiedName: "azurerm.hpcCache.HpcCacheDns")]
    public interface IHpcCacheDns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#servers HpcCache#servers}.</summary>
        [JsiiProperty(name: "servers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Servers
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#search_domain HpcCache#search_domain}.</summary>
        [JsiiProperty(name: "searchDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SearchDomain
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHpcCacheDns), fullyQualifiedName: "azurerm.hpcCache.HpcCacheDns")]
        internal sealed class _Proxy : DeputyBase, azurerm.HpcCache.IHpcCacheDns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#servers HpcCache#servers}.</summary>
            [JsiiProperty(name: "servers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Servers
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#search_domain HpcCache#search_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "searchDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SearchDomain
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
