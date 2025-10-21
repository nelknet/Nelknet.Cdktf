using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.InternetmonitorMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.internetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDeliveryS3Config")]
    public class InternetmonitorMonitorInternetMeasurementsLogDeliveryS3Config : aws.InternetmonitorMonitor.IInternetmonitorMonitorInternetMeasurementsLogDeliveryS3Config
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#bucket_name InternetmonitorMonitor#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#bucket_prefix InternetmonitorMonitor#bucket_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#log_delivery_status InternetmonitorMonitor#log_delivery_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logDeliveryStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogDeliveryStatus
        {
            get;
            set;
        }
    }
}
