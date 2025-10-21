using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchMetricStream
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchMetricStream.CloudwatchMetricStreamStatisticsConfigurationIncludeMetric")]
    public class CloudwatchMetricStreamStatisticsConfigurationIncludeMetric : aws.CloudwatchMetricStream.ICloudwatchMetricStreamStatisticsConfigurationIncludeMetric
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#metric_name CloudwatchMetricStream#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#namespace CloudwatchMetricStream#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }
    }
}
