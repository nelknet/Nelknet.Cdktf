using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.Firewall
{
    [JsiiInterface(nativeType: typeof(IFirewallApplyTo), fullyQualifiedName: "hcloud.firewall.FirewallApplyTo")]
    public interface IFirewallApplyTo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#label_selector Firewall#label_selector}.</summary>
        [JsiiProperty(name: "labelSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LabelSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#server Firewall#server}.</summary>
        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Server
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFirewallApplyTo), fullyQualifiedName: "hcloud.firewall.FirewallApplyTo")]
        internal sealed class _Proxy : DeputyBase, hcloud.Firewall.IFirewallApplyTo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#label_selector Firewall#label_selector}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "labelSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LabelSelector
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#server Firewall#server}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Server
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
