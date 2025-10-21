using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchMetricStream
{
    [JsiiInterface(nativeType: typeof(ICloudwatchMetricStreamStatisticsConfigurationIncludeMetric), fullyQualifiedName: "aws.cloudwatchMetricStream.CloudwatchMetricStreamStatisticsConfigurationIncludeMetric")]
    public interface ICloudwatchMetricStreamStatisticsConfigurationIncludeMetric
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#metric_name CloudwatchMetricStream#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        string MetricName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#namespace CloudwatchMetricStream#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchMetricStreamStatisticsConfigurationIncludeMetric), fullyQualifiedName: "aws.cloudwatchMetricStream.CloudwatchMetricStreamStatisticsConfigurationIncludeMetric")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchMetricStream.ICloudwatchMetricStreamStatisticsConfigurationIncludeMetric
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#metric_name CloudwatchMetricStream#metric_name}.</summary>
            [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#namespace CloudwatchMetricStream#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
