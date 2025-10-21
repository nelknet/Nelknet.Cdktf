using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DnsZone
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dnsZone.DnsZoneSoaRecord")]
    public class DnsZoneSoaRecord : azurerm.DnsZone.IDnsZoneSoaRecord
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone#email DnsZone#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public string Email
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone#expire_time DnsZone#expire_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expireTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpireTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone#minimum_ttl DnsZone#minimum_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinimumTtl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone#refresh_time DnsZone#refresh_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "refreshTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RefreshTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone#retry_time DnsZone#retry_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retryTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetryTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone#serial_number DnsZone#serial_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SerialNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone#tags DnsZone#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone#ttl DnsZone#ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ttl
        {
            get;
            set;
        }
    }
}
