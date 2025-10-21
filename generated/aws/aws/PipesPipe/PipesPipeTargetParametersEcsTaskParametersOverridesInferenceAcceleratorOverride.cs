using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride")]
    public class PipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride : aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#device_name PipesPipe#device_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeviceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#device_type PipesPipe#device_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeviceType
        {
            get;
            set;
        }
    }
}
