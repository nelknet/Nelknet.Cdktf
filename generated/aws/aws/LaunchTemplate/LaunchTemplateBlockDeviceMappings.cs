using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiByValue(fqn: "aws.launchTemplate.LaunchTemplateBlockDeviceMappings")]
    public class LaunchTemplateBlockDeviceMappings : aws.LaunchTemplate.ILaunchTemplateBlockDeviceMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#device_name LaunchTemplate#device_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeviceName
        {
            get;
            set;
        }

        /// <summary>ebs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#ebs LaunchTemplate#ebs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ebs", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateBlockDeviceMappingsEbs\"}", isOptional: true)]
        public aws.LaunchTemplate.ILaunchTemplateBlockDeviceMappingsEbs? Ebs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#no_device LaunchTemplate#no_device}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "noDevice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NoDevice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#virtual_name LaunchTemplate#virtual_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VirtualName
        {
            get;
            set;
        }
    }
}
