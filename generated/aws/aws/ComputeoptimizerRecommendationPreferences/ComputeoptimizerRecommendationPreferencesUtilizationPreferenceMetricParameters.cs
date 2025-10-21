using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComputeoptimizerRecommendationPreferences
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesUtilizationPreferenceMetricParameters")]
    public class ComputeoptimizerRecommendationPreferencesUtilizationPreferenceMetricParameters : aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesUtilizationPreferenceMetricParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#headroom ComputeoptimizerRecommendationPreferences#headroom}.</summary>
        [JsiiProperty(name: "headroom", typeJson: "{\"primitive\":\"string\"}")]
        public string Headroom
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#threshold ComputeoptimizerRecommendationPreferences#threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Threshold
        {
            get;
            set;
        }
    }
}
