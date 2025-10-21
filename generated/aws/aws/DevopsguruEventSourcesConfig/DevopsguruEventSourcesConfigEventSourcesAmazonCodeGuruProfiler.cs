using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruEventSourcesConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.devopsguruEventSourcesConfig.DevopsguruEventSourcesConfigEventSourcesAmazonCodeGuruProfiler")]
    public class DevopsguruEventSourcesConfigEventSourcesAmazonCodeGuruProfiler : aws.DevopsguruEventSourcesConfig.IDevopsguruEventSourcesConfigEventSourcesAmazonCodeGuruProfiler
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_event_sources_config#status DevopsguruEventSourcesConfig#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }
    }
}
