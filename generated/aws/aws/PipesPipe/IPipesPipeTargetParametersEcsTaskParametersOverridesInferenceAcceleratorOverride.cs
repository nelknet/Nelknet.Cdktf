using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride")]
    public interface IPipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#device_name PipesPipe#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeviceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#device_type PipesPipe#device_type}.</summary>
        [JsiiProperty(name: "deviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeviceType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#device_name PipesPipe#device_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeviceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#device_type PipesPipe#device_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeviceType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
