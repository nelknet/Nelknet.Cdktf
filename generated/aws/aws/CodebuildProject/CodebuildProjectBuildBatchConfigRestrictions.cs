using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    [JsiiByValue(fqn: "aws.codebuildProject.CodebuildProjectBuildBatchConfigRestrictions")]
    public class CodebuildProjectBuildBatchConfigRestrictions : aws.CodebuildProject.ICodebuildProjectBuildBatchConfigRestrictions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#compute_types_allowed CodebuildProject#compute_types_allowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeTypesAllowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ComputeTypesAllowed
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#maximum_builds_allowed CodebuildProject#maximum_builds_allowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumBuildsAllowed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumBuildsAllowed
        {
            get;
            set;
        }
    }
}
