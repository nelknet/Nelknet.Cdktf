using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    [JsiiByValue(fqn: "aws.codebuildProject.CodebuildProjectEnvironmentFleet")]
    public class CodebuildProjectEnvironmentFleet : aws.CodebuildProject.ICodebuildProjectEnvironmentFleet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#fleet_arn CodebuildProject#fleet_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fleetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FleetArn
        {
            get;
            set;
        }
    }
}
