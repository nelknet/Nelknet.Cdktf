using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuildProject.CodebuildProjectSecondarySources")]
    public class CodebuildProjectSecondarySources : aws.CodebuildProject.ICodebuildProjectSecondarySources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#source_identifier CodebuildProject#source_identifier}.</summary>
        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#type CodebuildProject#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#auth CodebuildProject#auth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourcesAuth\"}", isOptional: true)]
        public aws.CodebuildProject.ICodebuildProjectSecondarySourcesAuth? Auth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#buildspec CodebuildProject#buildspec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "buildspec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Buildspec
        {
            get;
            set;
        }

        /// <summary>build_status_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#build_status_config CodebuildProject#build_status_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "buildStatusConfig", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourcesBuildStatusConfig\"}", isOptional: true)]
        public aws.CodebuildProject.ICodebuildProjectSecondarySourcesBuildStatusConfig? BuildStatusConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#git_clone_depth CodebuildProject#git_clone_depth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gitCloneDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GitCloneDepth
        {
            get;
            set;
        }

        /// <summary>git_submodules_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#git_submodules_config CodebuildProject#git_submodules_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gitSubmodulesConfig", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourcesGitSubmodulesConfig\"}", isOptional: true)]
        public aws.CodebuildProject.ICodebuildProjectSecondarySourcesGitSubmodulesConfig? GitSubmodulesConfig
        {
            get;
            set;
        }

        private object? _insecureSsl;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#insecure_ssl CodebuildProject#insecure_ssl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "insecureSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? InsecureSsl
        {
            get => _insecureSsl;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _insecureSsl = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#location CodebuildProject#location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Location
        {
            get;
            set;
        }

        private object? _reportBuildStatus;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#report_build_status CodebuildProject#report_build_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reportBuildStatus", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ReportBuildStatus
        {
            get => _reportBuildStatus;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _reportBuildStatus = value;
            }
        }
    }
}
