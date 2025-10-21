using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodepipelineCustomActionType
{
    [JsiiInterface(nativeType: typeof(ICodepipelineCustomActionTypeOutputArtifactDetails), fullyQualifiedName: "aws.codepipelineCustomActionType.CodepipelineCustomActionTypeOutputArtifactDetails")]
    public interface ICodepipelineCustomActionTypeOutputArtifactDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#maximum_count CodepipelineCustomActionType#maximum_count}.</summary>
        [JsiiProperty(name: "maximumCount", typeJson: "{\"primitive\":\"number\"}")]
        double MaximumCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#minimum_count CodepipelineCustomActionType#minimum_count}.</summary>
        [JsiiProperty(name: "minimumCount", typeJson: "{\"primitive\":\"number\"}")]
        double MinimumCount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineCustomActionTypeOutputArtifactDetails), fullyQualifiedName: "aws.codepipelineCustomActionType.CodepipelineCustomActionTypeOutputArtifactDetails")]
        internal sealed class _Proxy : DeputyBase, aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeOutputArtifactDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#maximum_count CodepipelineCustomActionType#maximum_count}.</summary>
            [JsiiProperty(name: "maximumCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MaximumCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#minimum_count CodepipelineCustomActionType#minimum_count}.</summary>
            [JsiiProperty(name: "minimumCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MinimumCount
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
