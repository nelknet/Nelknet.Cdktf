using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opsworksInstance.OpsworksInstanceEphemeralBlockDevice")]
    public class OpsworksInstanceEphemeralBlockDevice : aws.OpsworksInstance.IOpsworksInstanceEphemeralBlockDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#device_name OpsworksInstance#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        public string DeviceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#virtual_name OpsworksInstance#virtual_name}.</summary>
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualName
        {
            get;
            set;
        }
    }
}
