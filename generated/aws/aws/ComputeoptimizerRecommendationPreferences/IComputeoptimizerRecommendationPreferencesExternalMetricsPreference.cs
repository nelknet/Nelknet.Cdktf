using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComputeoptimizerRecommendationPreferences
{
    [JsiiInterface(nativeType: typeof(IComputeoptimizerRecommendationPreferencesExternalMetricsPreference), fullyQualifiedName: "aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesExternalMetricsPreference")]
    public interface IComputeoptimizerRecommendationPreferencesExternalMetricsPreference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#source ComputeoptimizerRecommendationPreferences#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeoptimizerRecommendationPreferencesExternalMetricsPreference), fullyQualifiedName: "aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesExternalMetricsPreference")]
        internal sealed class _Proxy : DeputyBase, aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesExternalMetricsPreference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#source ComputeoptimizerRecommendationPreferences#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
