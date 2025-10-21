using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruEventSourcesConfig
{
    [JsiiByValue(fqn: "aws.devopsguruEventSourcesConfig.DevopsguruEventSourcesConfigEventSources")]
    public class DevopsguruEventSourcesConfigEventSources : aws.DevopsguruEventSourcesConfig.IDevopsguruEventSourcesConfigEventSources
    {
        private object? _amazonCodeGuruProfiler;

        /// <summary>amazon_code_guru_profiler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_event_sources_config#amazon_code_guru_profiler DevopsguruEventSourcesConfig#amazon_code_guru_profiler}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amazonCodeGuruProfiler", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruEventSourcesConfig.DevopsguruEventSourcesConfigEventSourcesAmazonCodeGuruProfiler\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AmazonCodeGuruProfiler
        {
            get => _amazonCodeGuruProfiler;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DevopsguruEventSourcesConfig.IDevopsguruEventSourcesConfigEventSourcesAmazonCodeGuruProfiler[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DevopsguruEventSourcesConfig.IDevopsguruEventSourcesConfigEventSourcesAmazonCodeGuruProfiler).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _amazonCodeGuruProfiler = value;
            }
        }
    }
}
