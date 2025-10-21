using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectSource), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectSource")]
    public interface ICodebuildProjectSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#type CodebuildProject#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#auth CodebuildProject#auth}
        /// </remarks>
        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSourceAuth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodebuildProject.ICodebuildProjectSourceAuth? Auth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#buildspec CodebuildProject#buildspec}.</summary>
        [JsiiProperty(name: "buildspec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Buildspec
        {
            get
            {
                return null;
            }
        }

        /// <summary>build_status_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#build_status_config CodebuildProject#build_status_config}
        /// </remarks>
        [JsiiProperty(name: "buildStatusConfig", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSourceBuildStatusConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodebuildProject.ICodebuildProjectSourceBuildStatusConfig? BuildStatusConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#git_clone_depth CodebuildProject#git_clone_depth}.</summary>
        [JsiiProperty(name: "gitCloneDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GitCloneDepth
        {
            get
            {
                return null;
            }
        }

        /// <summary>git_submodules_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#git_submodules_config CodebuildProject#git_submodules_config}
        /// </remarks>
        [JsiiProperty(name: "gitSubmodulesConfig", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSourceGitSubmodulesConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodebuildProject.ICodebuildProjectSourceGitSubmodulesConfig? GitSubmodulesConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#insecure_ssl CodebuildProject#insecure_ssl}.</summary>
        [JsiiProperty(name: "insecureSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InsecureSsl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#location CodebuildProject#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Location
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#report_build_status CodebuildProject#report_build_status}.</summary>
        [JsiiProperty(name: "reportBuildStatus", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReportBuildStatus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectSource), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectSource")]
        internal sealed class _Proxy : DeputyBase, aws.CodebuildProject.ICodebuildProjectSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#type CodebuildProject#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>auth block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#auth CodebuildProject#auth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSourceAuth\"}", isOptional: true)]
            public aws.CodebuildProject.ICodebuildProjectSourceAuth? Auth
            {
                get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectSourceAuth?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#buildspec CodebuildProject#buildspec}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "buildspec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Buildspec
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>build_status_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#build_status_config CodebuildProject#build_status_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buildStatusConfig", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSourceBuildStatusConfig\"}", isOptional: true)]
            public aws.CodebuildProject.ICodebuildProjectSourceBuildStatusConfig? BuildStatusConfig
            {
                get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectSourceBuildStatusConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#git_clone_depth CodebuildProject#git_clone_depth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gitCloneDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GitCloneDepth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>git_submodules_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#git_submodules_config CodebuildProject#git_submodules_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gitSubmodulesConfig", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSourceGitSubmodulesConfig\"}", isOptional: true)]
            public aws.CodebuildProject.ICodebuildProjectSourceGitSubmodulesConfig? GitSubmodulesConfig
            {
                get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectSourceGitSubmodulesConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#insecure_ssl CodebuildProject#insecure_ssl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "insecureSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? InsecureSsl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#location CodebuildProject#location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Location
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#report_build_status CodebuildProject#report_build_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reportBuildStatus", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ReportBuildStatus
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
