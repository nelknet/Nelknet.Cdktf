using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.InternetmonitorMonitor
{
    [JsiiByValue(fqn: "aws.internetmonitorMonitor.InternetmonitorMonitorHealthEventsConfig")]
    public class InternetmonitorMonitorHealthEventsConfig : aws.InternetmonitorMonitor.IInternetmonitorMonitorHealthEventsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#availability_score_threshold InternetmonitorMonitor#availability_score_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityScoreThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AvailabilityScoreThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#performance_score_threshold InternetmonitorMonitor#performance_score_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "performanceScoreThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PerformanceScoreThreshold
        {
            get;
            set;
        }
    }
}
