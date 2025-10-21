using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectLogsConfig), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectLogsConfig")]
    public interface ICodebuildProjectLogsConfig
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#cloudwatch_logs CodebuildProject#cloudwatch_logs}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfigCloudwatchLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodebuildProject.ICodebuildProjectLogsConfigCloudwatchLogs? CloudwatchLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#s3_logs CodebuildProject#s3_logs}
        /// </remarks>
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfigS3Logs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodebuildProject.ICodebuildProjectLogsConfigS3Logs? S3Logs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectLogsConfig), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectLogsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CodebuildProject.ICodebuildProjectLogsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#cloudwatch_logs CodebuildProject#cloudwatch_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfigCloudwatchLogs\"}", isOptional: true)]
            public aws.CodebuildProject.ICodebuildProjectLogsConfigCloudwatchLogs? CloudwatchLogs
            {
                get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectLogsConfigCloudwatchLogs?>();
            }

            /// <summary>s3_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#s3_logs CodebuildProject#s3_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfigS3Logs\"}", isOptional: true)]
            public aws.CodebuildProject.ICodebuildProjectLogsConfigS3Logs? S3Logs
            {
                get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectLogsConfigS3Logs?>();
            }
        }
    }
}
