using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.InternetmonitorMonitor
{
    [JsiiInterface(nativeType: typeof(IInternetmonitorMonitorHealthEventsConfig), fullyQualifiedName: "aws.internetmonitorMonitor.InternetmonitorMonitorHealthEventsConfig")]
    public interface IInternetmonitorMonitorHealthEventsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#availability_score_threshold InternetmonitorMonitor#availability_score_threshold}.</summary>
        [JsiiProperty(name: "availabilityScoreThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AvailabilityScoreThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#performance_score_threshold InternetmonitorMonitor#performance_score_threshold}.</summary>
        [JsiiProperty(name: "performanceScoreThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PerformanceScoreThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInternetmonitorMonitorHealthEventsConfig), fullyQualifiedName: "aws.internetmonitorMonitor.InternetmonitorMonitorHealthEventsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.InternetmonitorMonitor.IInternetmonitorMonitorHealthEventsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#availability_score_threshold InternetmonitorMonitor#availability_score_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityScoreThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AvailabilityScoreThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#performance_score_threshold InternetmonitorMonitor#performance_score_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "performanceScoreThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PerformanceScoreThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
