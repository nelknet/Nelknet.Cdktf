using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruEventSourcesConfig
{
    [JsiiInterface(nativeType: typeof(IDevopsguruEventSourcesConfigEventSources), fullyQualifiedName: "aws.devopsguruEventSourcesConfig.DevopsguruEventSourcesConfigEventSources")]
    public interface IDevopsguruEventSourcesConfigEventSources
    {
        /// <summary>amazon_code_guru_profiler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_event_sources_config#amazon_code_guru_profiler DevopsguruEventSourcesConfig#amazon_code_guru_profiler}
        /// </remarks>
        [JsiiProperty(name: "amazonCodeGuruProfiler", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruEventSourcesConfig.DevopsguruEventSourcesConfigEventSourcesAmazonCodeGuruProfiler\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AmazonCodeGuruProfiler
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsguruEventSourcesConfigEventSources), fullyQualifiedName: "aws.devopsguruEventSourcesConfig.DevopsguruEventSourcesConfigEventSources")]
        internal sealed class _Proxy : DeputyBase, aws.DevopsguruEventSourcesConfig.IDevopsguruEventSourcesConfigEventSources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>amazon_code_guru_profiler block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_event_sources_config#amazon_code_guru_profiler DevopsguruEventSourcesConfig#amazon_code_guru_profiler}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amazonCodeGuruProfiler", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruEventSourcesConfig.DevopsguruEventSourcesConfigEventSourcesAmazonCodeGuruProfiler\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AmazonCodeGuruProfiler
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
