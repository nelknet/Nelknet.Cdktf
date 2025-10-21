using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMonitoringSubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionMonitoringSubscription")]
    public class CloudfrontMonitoringSubscriptionMonitoringSubscription : aws.CloudfrontMonitoringSubscription.ICloudfrontMonitoringSubscriptionMonitoringSubscription
    {
        /// <summary>realtime_metrics_subscription_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_monitoring_subscription#realtime_metrics_subscription_config CloudfrontMonitoringSubscription#realtime_metrics_subscription_config}
        /// </remarks>
        [JsiiProperty(name: "realtimeMetricsSubscriptionConfig", typeJson: "{\"fqn\":\"aws.cloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig\"}")]
        public aws.CloudfrontMonitoringSubscription.ICloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig RealtimeMetricsSubscriptionConfig
        {
            get;
            set;
        }
    }
}
