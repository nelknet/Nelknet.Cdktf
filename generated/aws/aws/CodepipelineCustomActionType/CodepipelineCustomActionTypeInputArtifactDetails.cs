using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodepipelineCustomActionType
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codepipelineCustomActionType.CodepipelineCustomActionTypeInputArtifactDetails")]
    public class CodepipelineCustomActionTypeInputArtifactDetails : aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeInputArtifactDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#maximum_count CodepipelineCustomActionType#maximum_count}.</summary>
        [JsiiProperty(name: "maximumCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MaximumCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#minimum_count CodepipelineCustomActionType#minimum_count}.</summary>
        [JsiiProperty(name: "minimumCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MinimumCount
        {
            get;
            set;
        }
    }
}
