using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallFirewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewallFirewall.NetworkfirewallFirewallEncryptionConfiguration")]
    public class NetworkfirewallFirewallEncryptionConfiguration : aws.NetworkfirewallFirewall.INetworkfirewallFirewallEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#type NetworkfirewallFirewall#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#key_id NetworkfirewallFirewall#key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyId
        {
            get;
            set;
        }
    }
}
