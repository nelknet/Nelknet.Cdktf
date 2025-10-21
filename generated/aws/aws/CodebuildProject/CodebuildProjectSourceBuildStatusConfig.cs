using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    [JsiiByValue(fqn: "aws.codebuildProject.CodebuildProjectSourceBuildStatusConfig")]
    public class CodebuildProjectSourceBuildStatusConfig : aws.CodebuildProject.ICodebuildProjectSourceBuildStatusConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#context CodebuildProject#context}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "context", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Context
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#target_url CodebuildProject#target_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetUrl
        {
            get;
            set;
        }
    }
}
