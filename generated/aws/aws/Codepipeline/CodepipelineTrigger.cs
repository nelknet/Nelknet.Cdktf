using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineTrigger")]
    public class CodepipelineTrigger : aws.Codepipeline.ICodepipelineTrigger
    {
        /// <summary>git_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#git_configuration Codepipeline#git_configuration}
        /// </remarks>
        [JsiiProperty(name: "gitConfiguration", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfiguration\"}")]
        public aws.Codepipeline.ICodepipelineTriggerGitConfiguration GitConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#provider_type Codepipeline#provider_type}.</summary>
        [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
        public string ProviderType
        {
            get;
            set;
        }
    }
}
