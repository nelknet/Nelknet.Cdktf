using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.Zone
{
    [JsiiInterface(nativeType: typeof(IZonePrimaryNameservers), fullyQualifiedName: "hcloud.zone.ZonePrimaryNameservers")]
    public interface IZonePrimaryNameservers
    {
        /// <summary>Public IPv4 or IPv6 address of the primary nameserver.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#address Zone#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        /// <summary>Port of the primary nameserver.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#port Zone#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Transaction signature (TSIG) algorithm used to generate the TSIG key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#tsig_algorithm Zone#tsig_algorithm}
        /// </remarks>
        [JsiiProperty(name: "tsigAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TsigAlgorithm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Transaction signature (TSIG) key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#tsig_key Zone#tsig_key}
        /// </remarks>
        [JsiiProperty(name: "tsigKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TsigKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZonePrimaryNameservers), fullyQualifiedName: "hcloud.zone.ZonePrimaryNameservers")]
        internal sealed class _Proxy : DeputyBase, hcloud.Zone.IZonePrimaryNameservers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Public IPv4 or IPv6 address of the primary nameserver.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#address Zone#address}
            /// </remarks>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Port of the primary nameserver.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#port Zone#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Transaction signature (TSIG) algorithm used to generate the TSIG key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#tsig_algorithm Zone#tsig_algorithm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tsigAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TsigAlgorithm
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Transaction signature (TSIG) key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#tsig_key Zone#tsig_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tsigKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TsigKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
