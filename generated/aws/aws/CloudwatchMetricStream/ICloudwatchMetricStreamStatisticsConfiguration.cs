using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchMetricStream
{
    [JsiiInterface(nativeType: typeof(ICloudwatchMetricStreamStatisticsConfiguration), fullyQualifiedName: "aws.cloudwatchMetricStream.CloudwatchMetricStreamStatisticsConfiguration")]
    public interface ICloudwatchMetricStreamStatisticsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#additional_statistics CloudwatchMetricStream#additional_statistics}.</summary>
        [JsiiProperty(name: "additionalStatistics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AdditionalStatistics
        {
            get;
        }

        /// <summary>include_metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#include_metric CloudwatchMetricStream#include_metric}
        /// </remarks>
        [JsiiProperty(name: "includeMetric", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchMetricStream.CloudwatchMetricStreamStatisticsConfigurationIncludeMetric\"},\"kind\":\"array\"}}]}}")]
        object IncludeMetric
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchMetricStreamStatisticsConfiguration), fullyQualifiedName: "aws.cloudwatchMetricStream.CloudwatchMetricStreamStatisticsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchMetricStream.ICloudwatchMetricStreamStatisticsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#additional_statistics CloudwatchMetricStream#additional_statistics}.</summary>
            [JsiiProperty(name: "additionalStatistics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AdditionalStatistics
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>include_metric block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#include_metric CloudwatchMetricStream#include_metric}
            /// </remarks>
            [JsiiProperty(name: "includeMetric", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchMetricStream.CloudwatchMetricStreamStatisticsConfigurationIncludeMetric\"},\"kind\":\"array\"}}]}}")]
            public object IncludeMetric
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
