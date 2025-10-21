using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMonitoringSubscription
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig), fullyQualifiedName: "aws.cloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig")]
    public interface ICloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_monitoring_subscription#realtime_metrics_subscription_status CloudfrontMonitoringSubscription#realtime_metrics_subscription_status}.</summary>
        [JsiiProperty(name: "realtimeMetricsSubscriptionStatus", typeJson: "{\"primitive\":\"string\"}")]
        string RealtimeMetricsSubscriptionStatus
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig), fullyQualifiedName: "aws.cloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMonitoringSubscription.ICloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_monitoring_subscription#realtime_metrics_subscription_status CloudfrontMonitoringSubscription#realtime_metrics_subscription_status}.</summary>
            [JsiiProperty(name: "realtimeMetricsSubscriptionStatus", typeJson: "{\"primitive\":\"string\"}")]
            public string RealtimeMetricsSubscriptionStatus
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
