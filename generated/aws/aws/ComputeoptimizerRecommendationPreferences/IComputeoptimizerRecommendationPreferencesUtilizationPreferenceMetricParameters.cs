using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComputeoptimizerRecommendationPreferences
{
    [JsiiInterface(nativeType: typeof(IComputeoptimizerRecommendationPreferencesUtilizationPreferenceMetricParameters), fullyQualifiedName: "aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesUtilizationPreferenceMetricParameters")]
    public interface IComputeoptimizerRecommendationPreferencesUtilizationPreferenceMetricParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#headroom ComputeoptimizerRecommendationPreferences#headroom}.</summary>
        [JsiiProperty(name: "headroom", typeJson: "{\"primitive\":\"string\"}")]
        string Headroom
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#threshold ComputeoptimizerRecommendationPreferences#threshold}.</summary>
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Threshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeoptimizerRecommendationPreferencesUtilizationPreferenceMetricParameters), fullyQualifiedName: "aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesUtilizationPreferenceMetricParameters")]
        internal sealed class _Proxy : DeputyBase, aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesUtilizationPreferenceMetricParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#headroom ComputeoptimizerRecommendationPreferences#headroom}.</summary>
            [JsiiProperty(name: "headroom", typeJson: "{\"primitive\":\"string\"}")]
            public string Headroom
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#threshold ComputeoptimizerRecommendationPreferences#threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Threshold
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
