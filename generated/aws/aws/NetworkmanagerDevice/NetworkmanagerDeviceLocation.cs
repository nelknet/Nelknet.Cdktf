using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerDevice
{
    [JsiiByValue(fqn: "aws.networkmanagerDevice.NetworkmanagerDeviceLocation")]
    public class NetworkmanagerDeviceLocation : aws.NetworkmanagerDevice.INetworkmanagerDeviceLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#address NetworkmanagerDevice#address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#latitude NetworkmanagerDevice#latitude}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Latitude
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#longitude NetworkmanagerDevice#longitude}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Longitude
        {
            get;
            set;
        }
    }
}
