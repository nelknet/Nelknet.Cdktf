using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuildProject.CodebuildProjectEnvironment")]
    public class CodebuildProjectEnvironment : aws.CodebuildProject.ICodebuildProjectEnvironment
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#compute_type CodebuildProject#compute_type}.</summary>
        [JsiiProperty(name: "computeType", typeJson: "{\"primitive\":\"string\"}")]
        public string ComputeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#image CodebuildProject#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public string Image
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#certificate CodebuildProject#certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Certificate
        {
            get;
            set;
        }

        private object? _environmentVariable;

        /// <summary>environment_variable block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#environment_variable CodebuildProject#environment_variable}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environmentVariable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironmentEnvironmentVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EnvironmentVariable
        {
            get => _environmentVariable;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CodebuildProject.ICodebuildProjectEnvironmentEnvironmentVariable[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectEnvironmentEnvironmentVariable).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _environmentVariable = value;
            }
        }

        /// <summary>fleet block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#fleet CodebuildProject#fleet}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fleet", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironmentFleet\"}", isOptional: true)]
        public aws.CodebuildProject.ICodebuildProjectEnvironmentFleet? Fleet
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#image_pull_credentials_type CodebuildProject#image_pull_credentials_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imagePullCredentialsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImagePullCredentialsType
        {
            get;
            set;
        }

        private object? _privilegedMode;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#privileged_mode CodebuildProject#privileged_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privilegedMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PrivilegedMode
        {
            get => _privilegedMode;
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
                _privilegedMode = value;
            }
        }

        /// <summary>registry_credential block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#registry_credential CodebuildProject#registry_credential}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registryCredential", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironmentRegistryCredential\"}", isOptional: true)]
        public aws.CodebuildProject.ICodebuildProjectEnvironmentRegistryCredential? RegistryCredential
        {
            get;
            set;
        }
    }
}
