using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodeguruprofilerProfilingGroup
{
    [JsiiInterface(nativeType: typeof(ICodeguruprofilerProfilingGroupAgentOrchestrationConfig), fullyQualifiedName: "aws.codeguruprofilerProfilingGroup.CodeguruprofilerProfilingGroupAgentOrchestrationConfig")]
    public interface ICodeguruprofilerProfilingGroupAgentOrchestrationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeguruprofiler_profiling_group#profiling_enabled CodeguruprofilerProfilingGroup#profiling_enabled}.</summary>
        [JsiiProperty(name: "profilingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object ProfilingEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodeguruprofilerProfilingGroupAgentOrchestrationConfig), fullyQualifiedName: "aws.codeguruprofilerProfilingGroup.CodeguruprofilerProfilingGroupAgentOrchestrationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CodeguruprofilerProfilingGroup.ICodeguruprofilerProfilingGroupAgentOrchestrationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeguruprofiler_profiling_group#profiling_enabled CodeguruprofilerProfilingGroup#profiling_enabled}.</summary>
            [JsiiProperty(name: "profilingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object ProfilingEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
