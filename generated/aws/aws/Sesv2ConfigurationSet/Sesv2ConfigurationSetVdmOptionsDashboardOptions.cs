using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSet
{
    [JsiiByValue(fqn: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsDashboardOptions")]
    public class Sesv2ConfigurationSetVdmOptionsDashboardOptions : aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsDashboardOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#engagement_metrics Sesv2ConfigurationSet#engagement_metrics}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engagementMetrics", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EngagementMetrics
        {
            get;
            set;
        }
    }
}
