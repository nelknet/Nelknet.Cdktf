using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeTargetParametersLambdaFunctionParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersLambdaFunctionParameters")]
    public interface IPipesPipeTargetParametersLambdaFunctionParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#invocation_type PipesPipe#invocation_type}.</summary>
        [JsiiProperty(name: "invocationType", typeJson: "{\"primitive\":\"string\"}")]
        string InvocationType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeTargetParametersLambdaFunctionParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersLambdaFunctionParameters")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeTargetParametersLambdaFunctionParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#invocation_type PipesPipe#invocation_type}.</summary>
            [JsiiProperty(name: "invocationType", typeJson: "{\"primitive\":\"string\"}")]
            public string InvocationType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
