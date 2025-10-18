using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.Firewall
{
    [JsiiByValue(fqn: "hcloud.firewall.FirewallApplyTo")]
    public class FirewallApplyTo : hcloud.Firewall.IFirewallApplyTo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#label_selector Firewall#label_selector}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labelSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LabelSelector
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#server Firewall#server}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Server
        {
            get;
            set;
        }
    }
}
