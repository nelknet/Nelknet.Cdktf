using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.ZoneRrset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "hcloud.zoneRrset.ZoneRrsetRecords")]
    public class ZoneRrsetRecords : hcloud.ZoneRrset.IZoneRrsetRecords
    {
        /// <summary>Value of the record.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#value ZoneRrset#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Comment of the record.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#comment ZoneRrset#comment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Comment
        {
            get;
            set;
        }
    }
}
