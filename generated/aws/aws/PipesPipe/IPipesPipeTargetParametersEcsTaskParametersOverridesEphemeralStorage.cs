using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage")]
    public interface IPipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#size_in_gib PipesPipe#size_in_gib}.</summary>
        [JsiiProperty(name: "sizeInGib", typeJson: "{\"primitive\":\"number\"}")]
        double SizeInGib
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#size_in_gib PipesPipe#size_in_gib}.</summary>
            [JsiiProperty(name: "sizeInGib", typeJson: "{\"primitive\":\"number\"}")]
            public double SizeInGib
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
