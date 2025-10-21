using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lightsailInstance.LightsailInstanceAddOn")]
    public class LightsailInstanceAddOn : aws.LightsailInstance.ILightsailInstanceAddOn
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#snapshot_time LightsailInstance#snapshot_time}.</summary>
        [JsiiProperty(name: "snapshotTime", typeJson: "{\"primitive\":\"string\"}")]
        public string SnapshotTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#status LightsailInstance#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#type LightsailInstance#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
