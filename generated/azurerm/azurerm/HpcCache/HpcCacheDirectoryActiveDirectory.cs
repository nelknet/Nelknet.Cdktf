using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCache
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hpcCache.HpcCacheDirectoryActiveDirectory")]
    public class HpcCacheDirectoryActiveDirectory : azurerm.HpcCache.IHpcCacheDirectoryActiveDirectory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#cache_netbios_name HpcCache#cache_netbios_name}.</summary>
        [JsiiProperty(name: "cacheNetbiosName", typeJson: "{\"primitive\":\"string\"}")]
        public string CacheNetbiosName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#dns_primary_ip HpcCache#dns_primary_ip}.</summary>
        [JsiiProperty(name: "dnsPrimaryIp", typeJson: "{\"primitive\":\"string\"}")]
        public string DnsPrimaryIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#domain_name HpcCache#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#domain_netbios_name HpcCache#domain_netbios_name}.</summary>
        [JsiiProperty(name: "domainNetbiosName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainNetbiosName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#password HpcCache#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#username HpcCache#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#dns_secondary_ip HpcCache#dns_secondary_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsSecondaryIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsSecondaryIp
        {
            get;
            set;
        }
    }
}
