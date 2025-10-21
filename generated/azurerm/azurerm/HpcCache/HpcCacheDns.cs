using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCache
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hpcCache.HpcCacheDns")]
    public class HpcCacheDns : azurerm.HpcCache.IHpcCacheDns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#servers HpcCache#servers}.</summary>
        [JsiiProperty(name: "servers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Servers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#search_domain HpcCache#search_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "searchDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SearchDomain
        {
            get;
            set;
        }
    }
}
