using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.Server
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "hcloud.server.ServerNetwork")]
    public class ServerNetwork : hcloud.Server.IServerNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#network_id Server#network_id}.</summary>
        [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"number\"}")]
        public double NetworkId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#alias_ips Server#alias_ips}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aliasIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AliasIps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ip Server#ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ip
        {
            get;
            set;
        }
    }
}
