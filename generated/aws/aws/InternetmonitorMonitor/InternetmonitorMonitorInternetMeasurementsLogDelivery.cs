using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.InternetmonitorMonitor
{
    [JsiiByValue(fqn: "aws.internetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDelivery")]
    public class InternetmonitorMonitorInternetMeasurementsLogDelivery : aws.InternetmonitorMonitor.IInternetmonitorMonitorInternetMeasurementsLogDelivery
    {
        /// <summary>s3_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#s3_config InternetmonitorMonitor#s3_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Config", typeJson: "{\"fqn\":\"aws.internetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDeliveryS3Config\"}", isOptional: true)]
        public aws.InternetmonitorMonitor.IInternetmonitorMonitorInternetMeasurementsLogDeliveryS3Config? S3Config
        {
            get;
            set;
        }
    }
}
