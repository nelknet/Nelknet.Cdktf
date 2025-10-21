using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeSourceParametersFilterCriteriaFilter), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersFilterCriteriaFilter")]
    public interface IPipesPipeSourceParametersFilterCriteriaFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#pattern PipesPipe#pattern}.</summary>
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
        string Pattern
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeSourceParametersFilterCriteriaFilter), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersFilterCriteriaFilter")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeSourceParametersFilterCriteriaFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#pattern PipesPipe#pattern}.</summary>
            [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
            public string Pattern
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
