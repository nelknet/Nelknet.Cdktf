using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruEventSourcesConfig
{
    [JsiiInterface(nativeType: typeof(IDevopsguruEventSourcesConfigEventSourcesAmazonCodeGuruProfiler), fullyQualifiedName: "aws.devopsguruEventSourcesConfig.DevopsguruEventSourcesConfigEventSourcesAmazonCodeGuruProfiler")]
    public interface IDevopsguruEventSourcesConfigEventSourcesAmazonCodeGuruProfiler
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_event_sources_config#status DevopsguruEventSourcesConfig#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsguruEventSourcesConfigEventSourcesAmazonCodeGuruProfiler), fullyQualifiedName: "aws.devopsguruEventSourcesConfig.DevopsguruEventSourcesConfigEventSourcesAmazonCodeGuruProfiler")]
        internal sealed class _Proxy : DeputyBase, aws.DevopsguruEventSourcesConfig.IDevopsguruEventSourcesConfigEventSourcesAmazonCodeGuruProfiler
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_event_sources_config#status DevopsguruEventSourcesConfig#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
