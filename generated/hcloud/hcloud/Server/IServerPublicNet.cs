using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.Server
{
    [JsiiInterface(nativeType: typeof(IServerPublicNet), fullyQualifiedName: "hcloud.server.ServerPublicNet")]
    public interface IServerPublicNet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ipv4 Server#ipv4}.</summary>
        [JsiiProperty(name: "ipv4", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ipv4
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ipv4_enabled Server#ipv4_enabled}.</summary>
        [JsiiProperty(name: "ipv4Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ipv4Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ipv6 Server#ipv6}.</summary>
        [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ipv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ipv6_enabled Server#ipv6_enabled}.</summary>
        [JsiiProperty(name: "ipv6Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ipv6Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServerPublicNet), fullyQualifiedName: "hcloud.server.ServerPublicNet")]
        internal sealed class _Proxy : DeputyBase, hcloud.Server.IServerPublicNet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ipv4 Server#ipv4}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv4", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ipv4
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ipv4_enabled Server#ipv4_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv4Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Ipv4Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ipv6 Server#ipv6}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ipv6
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ipv6_enabled Server#ipv6_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Ipv6Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
