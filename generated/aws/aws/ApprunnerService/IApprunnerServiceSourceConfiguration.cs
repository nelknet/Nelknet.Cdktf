using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiInterface(nativeType: typeof(IApprunnerServiceSourceConfiguration), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceSourceConfiguration")]
    public interface IApprunnerServiceSourceConfiguration
    {
        /// <summary>authentication_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#authentication_configuration ApprunnerService#authentication_configuration}
        /// </remarks>
        [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationAuthenticationConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ApprunnerService.IApprunnerServiceSourceConfigurationAuthenticationConfiguration? AuthenticationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#auto_deployments_enabled ApprunnerService#auto_deployments_enabled}.</summary>
        [JsiiProperty(name: "autoDeploymentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoDeploymentsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>code_repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#code_repository ApprunnerService#code_repository}
        /// </remarks>
        [JsiiProperty(name: "codeRepository", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepository\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepository? CodeRepository
        {
            get
            {
                return null;
            }
        }

        /// <summary>image_repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#image_repository ApprunnerService#image_repository}
        /// </remarks>
        [JsiiProperty(name: "imageRepository", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepository\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepository? ImageRepository
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerServiceSourceConfiguration), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceSourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ApprunnerService.IApprunnerServiceSourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>authentication_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#authentication_configuration ApprunnerService#authentication_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationAuthenticationConfiguration\"}", isOptional: true)]
            public aws.ApprunnerService.IApprunnerServiceSourceConfigurationAuthenticationConfiguration? AuthenticationConfiguration
            {
                get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceSourceConfigurationAuthenticationConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#auto_deployments_enabled ApprunnerService#auto_deployments_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoDeploymentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AutoDeploymentsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>code_repository block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#code_repository ApprunnerService#code_repository}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeRepository", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepository\"}", isOptional: true)]
            public aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepository? CodeRepository
            {
                get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepository?>();
            }

            /// <summary>image_repository block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#image_repository ApprunnerService#image_repository}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageRepository", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepository\"}", isOptional: true)]
            public aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepository? ImageRepository
            {
                get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepository?>();
            }
        }
    }
}
