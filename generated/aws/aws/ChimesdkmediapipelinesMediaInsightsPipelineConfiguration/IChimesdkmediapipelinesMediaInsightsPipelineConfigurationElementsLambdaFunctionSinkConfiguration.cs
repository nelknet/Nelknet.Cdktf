using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration
{
    [JsiiInterface(nativeType: typeof(IChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsLambdaFunctionSinkConfiguration), fullyQualifiedName: "aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsLambdaFunctionSinkConfiguration")]
    public interface IChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsLambdaFunctionSinkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#insights_target ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#insights_target}.</summary>
        [JsiiProperty(name: "insightsTarget", typeJson: "{\"primitive\":\"string\"}")]
        string InsightsTarget
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsLambdaFunctionSinkConfiguration), fullyQualifiedName: "aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsLambdaFunctionSinkConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsLambdaFunctionSinkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#insights_target ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#insights_target}.</summary>
            [JsiiProperty(name: "insightsTarget", typeJson: "{\"primitive\":\"string\"}")]
            public string InsightsTarget
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
