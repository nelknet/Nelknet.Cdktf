using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerObservabilityConfiguration
{
    [JsiiByValue(fqn: "aws.apprunnerObservabilityConfiguration.ApprunnerObservabilityConfigurationTraceConfiguration")]
    public class ApprunnerObservabilityConfigurationTraceConfiguration : aws.ApprunnerObservabilityConfiguration.IApprunnerObservabilityConfigurationTraceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_observability_configuration#vendor ApprunnerObservabilityConfiguration#vendor}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vendor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Vendor
        {
            get;
            set;
        }
    }
}
