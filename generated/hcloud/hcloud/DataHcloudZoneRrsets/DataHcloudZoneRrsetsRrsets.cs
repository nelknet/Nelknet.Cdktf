using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudZoneRrsets
{
    [JsiiByValue(fqn: "hcloud.dataHcloudZoneRrsets.DataHcloudZoneRrsetsRrsets")]
    public class DataHcloudZoneRrsetsRrsets : hcloud.DataHcloudZoneRrsets.IDataHcloudZoneRrsetsRrsets
    {
        /// <summary>ID or Name of the parent Zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrsets#zone DataHcloudZoneRrsets#zone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Zone
        {
            get;
            set;
        }
    }
}
