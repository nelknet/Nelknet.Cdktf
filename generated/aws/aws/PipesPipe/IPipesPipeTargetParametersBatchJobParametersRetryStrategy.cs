using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeTargetParametersBatchJobParametersRetryStrategy), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersRetryStrategy")]
    public interface IPipesPipeTargetParametersBatchJobParametersRetryStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#attempts PipesPipe#attempts}.</summary>
        [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Attempts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeTargetParametersBatchJobParametersRetryStrategy), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersRetryStrategy")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersRetryStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#attempts PipesPipe#attempts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Attempts
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
