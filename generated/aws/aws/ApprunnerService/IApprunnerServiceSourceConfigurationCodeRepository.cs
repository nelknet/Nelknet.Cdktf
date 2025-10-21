using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiInterface(nativeType: typeof(IApprunnerServiceSourceConfigurationCodeRepository), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepository")]
    public interface IApprunnerServiceSourceConfigurationCodeRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#repository_url ApprunnerService#repository_url}.</summary>
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryUrl
        {
            get;
        }

        /// <summary>source_code_version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#source_code_version ApprunnerService#source_code_version}
        /// </remarks>
        [JsiiProperty(name: "sourceCodeVersion", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion\"}")]
        aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion SourceCodeVersion
        {
            get;
        }

        /// <summary>code_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#code_configuration ApprunnerService#code_configuration}
        /// </remarks>
        [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration? CodeConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#source_directory ApprunnerService#source_directory}.</summary>
        [JsiiProperty(name: "sourceDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceDirectory
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerServiceSourceConfigurationCodeRepository), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepository")]
        internal sealed class _Proxy : DeputyBase, aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepository
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#repository_url ApprunnerService#repository_url}.</summary>
            [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>source_code_version block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#source_code_version ApprunnerService#source_code_version}
            /// </remarks>
            [JsiiProperty(name: "sourceCodeVersion", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion\"}")]
            public aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion SourceCodeVersion
            {
                get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion>()!;
            }

            /// <summary>code_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#code_configuration ApprunnerService#code_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration\"}", isOptional: true)]
            public aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration? CodeConfiguration
            {
                get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#source_directory ApprunnerService#source_directory}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceDirectory
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
