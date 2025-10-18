using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudZoneRrsets
{
    [JsiiInterface(nativeType: typeof(IDataHcloudZoneRrsetsRrsets), fullyQualifiedName: "hcloud.dataHcloudZoneRrsets.DataHcloudZoneRrsetsRrsets")]
    public interface IDataHcloudZoneRrsetsRrsets
    {
        /// <summary>ID or Name of the parent Zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrsets#zone DataHcloudZoneRrsets#zone}
        /// </remarks>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Zone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataHcloudZoneRrsetsRrsets), fullyQualifiedName: "hcloud.dataHcloudZoneRrsets.DataHcloudZoneRrsetsRrsets")]
        internal sealed class _Proxy : DeputyBase, hcloud.DataHcloudZoneRrsets.IDataHcloudZoneRrsetsRrsets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID or Name of the parent Zone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrsets#zone DataHcloudZoneRrsets#zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
