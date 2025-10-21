using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComputeoptimizerRecommendationPreferences
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesUtilizationPreference")]
    public class ComputeoptimizerRecommendationPreferencesUtilizationPreference : aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesUtilizationPreference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#metric_name ComputeoptimizerRecommendationPreferences#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricName
        {
            get;
            set;
        }

        private object? _metricParameters;

        /// <summary>metric_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#metric_parameters ComputeoptimizerRecommendationPreferences#metric_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metricParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesUtilizationPreferenceMetricParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MetricParameters
        {
            get => _metricParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesUtilizationPreferenceMetricParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesUtilizationPreferenceMetricParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _metricParameters = value;
            }
        }
    }
}
