using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile")]
    public interface IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#type PipesPipe#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#value PipesPipe#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#type PipesPipe#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#value PipesPipe#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
