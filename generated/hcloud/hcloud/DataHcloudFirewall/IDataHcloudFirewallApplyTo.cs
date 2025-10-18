using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudFirewall
{
    [JsiiInterface(nativeType: typeof(IDataHcloudFirewallApplyTo), fullyQualifiedName: "hcloud.dataHcloudFirewall.DataHcloudFirewallApplyTo")]
    public interface IDataHcloudFirewallApplyTo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#label_selector DataHcloudFirewall#label_selector}.</summary>
        [JsiiProperty(name: "labelSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LabelSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#server DataHcloudFirewall#server}.</summary>
        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Server
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataHcloudFirewallApplyTo), fullyQualifiedName: "hcloud.dataHcloudFirewall.DataHcloudFirewallApplyTo")]
        internal sealed class _Proxy : DeputyBase, hcloud.DataHcloudFirewall.IDataHcloudFirewallApplyTo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#label_selector DataHcloudFirewall#label_selector}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "labelSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LabelSelector
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#server DataHcloudFirewall#server}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Server
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
