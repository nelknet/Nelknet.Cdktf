using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.Zone
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "hcloud.zone.ZonePrimaryNameservers")]
    public class ZonePrimaryNameservers : hcloud.Zone.IZonePrimaryNameservers
    {
        /// <summary>Public IPv4 or IPv6 address of the primary nameserver.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#address Zone#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>Port of the primary nameserver.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#port Zone#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Transaction signature (TSIG) algorithm used to generate the TSIG key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#tsig_algorithm Zone#tsig_algorithm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tsigAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TsigAlgorithm
        {
            get;
            set;
        }

        /// <summary>Transaction signature (TSIG) key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#tsig_key Zone#tsig_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tsigKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TsigKey
        {
            get;
            set;
        }
    }
}
