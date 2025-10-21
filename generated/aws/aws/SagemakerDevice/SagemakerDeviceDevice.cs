using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDevice
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerDevice.SagemakerDeviceDevice")]
    public class SagemakerDeviceDevice : aws.SagemakerDevice.ISagemakerDeviceDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device#device_name SagemakerDevice#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        public string DeviceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device#description SagemakerDevice#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device#iot_thing_name SagemakerDevice#iot_thing_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iotThingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IotThingName
        {
            get;
            set;
        }
    }
}
