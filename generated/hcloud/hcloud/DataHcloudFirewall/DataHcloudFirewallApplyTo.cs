using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudFirewall
{
    [JsiiByValue(fqn: "hcloud.dataHcloudFirewall.DataHcloudFirewallApplyTo")]
    public class DataHcloudFirewallApplyTo : hcloud.DataHcloudFirewall.IDataHcloudFirewallApplyTo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#label_selector DataHcloudFirewall#label_selector}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labelSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LabelSelector
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#server DataHcloudFirewall#server}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Server
        {
            get;
            set;
        }
    }
}
