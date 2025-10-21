using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerDevice
{
    [JsiiByValue(fqn: "aws.networkmanagerDevice.NetworkmanagerDeviceAwsLocation")]
    public class NetworkmanagerDeviceAwsLocation : aws.NetworkmanagerDevice.INetworkmanagerDeviceAwsLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#subnet_arn NetworkmanagerDevice#subnet_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#zone NetworkmanagerDevice#zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Zone
        {
            get;
            set;
        }
    }
}
