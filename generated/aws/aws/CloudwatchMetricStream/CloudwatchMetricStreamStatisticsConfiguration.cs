using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchMetricStream
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchMetricStream.CloudwatchMetricStreamStatisticsConfiguration")]
    public class CloudwatchMetricStreamStatisticsConfiguration : aws.CloudwatchMetricStream.ICloudwatchMetricStreamStatisticsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#additional_statistics CloudwatchMetricStream#additional_statistics}.</summary>
        [JsiiProperty(name: "additionalStatistics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AdditionalStatistics
        {
            get;
            set;
        }

        private object _includeMetric;

        /// <summary>include_metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#include_metric CloudwatchMetricStream#include_metric}
        /// </remarks>
        [JsiiProperty(name: "includeMetric", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchMetricStream.CloudwatchMetricStreamStatisticsConfigurationIncludeMetric\"},\"kind\":\"array\"}}]}}")]
        public object IncludeMetric
        {
            get => _includeMetric;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchMetricStream.ICloudwatchMetricStreamStatisticsConfigurationIncludeMetric[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudwatchMetricStream.ICloudwatchMetricStreamStatisticsConfigurationIncludeMetric).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudwatchMetricStream.ICloudwatchMetricStreamStatisticsConfigurationIncludeMetric).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _includeMetric = value;
            }
        }
    }
}
