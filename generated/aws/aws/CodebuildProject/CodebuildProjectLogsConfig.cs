using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    [JsiiByValue(fqn: "aws.codebuildProject.CodebuildProjectLogsConfig")]
    public class CodebuildProjectLogsConfig : aws.CodebuildProject.ICodebuildProjectLogsConfig
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#cloudwatch_logs CodebuildProject#cloudwatch_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfigCloudwatchLogs\"}", isOptional: true)]
        public aws.CodebuildProject.ICodebuildProjectLogsConfigCloudwatchLogs? CloudwatchLogs
        {
            get;
            set;
        }

        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#s3_logs CodebuildProject#s3_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfigS3Logs\"}", isOptional: true)]
        public aws.CodebuildProject.ICodebuildProjectLogsConfigS3Logs? S3Logs
        {
            get;
            set;
        }
    }
}
