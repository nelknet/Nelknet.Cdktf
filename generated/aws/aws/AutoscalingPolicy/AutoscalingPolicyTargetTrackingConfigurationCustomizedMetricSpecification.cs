using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingPolicy
{
    [JsiiByValue(fqn: "aws.autoscalingPolicy.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification")]
    public class AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification : aws.AutoscalingPolicy.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification
    {
        private object? _metricDimension;

        /// <summary>metric_dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#metric_dimension AutoscalingPolicy#metric_dimension}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metricDimension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingPolicy.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MetricDimension
        {
            get => _metricDimension;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AutoscalingPolicy.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AutoscalingPolicy.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _metricDimension = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#metric_name AutoscalingPolicy#metric_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricName
        {
            get;
            set;
        }

        private object? _metrics;

        /// <summary>metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#metrics AutoscalingPolicy#metrics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metrics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingPolicy.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetrics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Metrics
        {
            get => _metrics;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AutoscalingPolicy.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetrics[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AutoscalingPolicy.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetrics).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _metrics = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#namespace AutoscalingPolicy#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#period AutoscalingPolicy#period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Period
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#statistic AutoscalingPolicy#statistic}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "statistic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Statistic
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#unit AutoscalingPolicy#unit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Unit
        {
            get;
            set;
        }
    }
}
