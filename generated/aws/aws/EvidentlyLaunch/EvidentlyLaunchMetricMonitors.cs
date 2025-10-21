using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyLaunch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.evidentlyLaunch.EvidentlyLaunchMetricMonitors")]
    public class EvidentlyLaunchMetricMonitors : aws.EvidentlyLaunch.IEvidentlyLaunchMetricMonitors
    {
        /// <summary>metric_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#metric_definition EvidentlyLaunch#metric_definition}
        /// </remarks>
        [JsiiProperty(name: "metricDefinition", typeJson: "{\"fqn\":\"aws.evidentlyLaunch.EvidentlyLaunchMetricMonitorsMetricDefinition\"}")]
        public aws.EvidentlyLaunch.IEvidentlyLaunchMetricMonitorsMetricDefinition MetricDefinition
        {
            get;
            set;
        }
    }
}
