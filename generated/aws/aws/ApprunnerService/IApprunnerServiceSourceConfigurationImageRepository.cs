using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiInterface(nativeType: typeof(IApprunnerServiceSourceConfigurationImageRepository), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepository")]
    public interface IApprunnerServiceSourceConfigurationImageRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#image_identifier ApprunnerService#image_identifier}.</summary>
        [JsiiProperty(name: "imageIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ImageIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#image_repository_type ApprunnerService#image_repository_type}.</summary>
        [JsiiProperty(name: "imageRepositoryType", typeJson: "{\"primitive\":\"string\"}")]
        string ImageRepositoryType
        {
            get;
        }

        /// <summary>image_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#image_configuration ApprunnerService#image_configuration}
        /// </remarks>
        [JsiiProperty(name: "imageConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration? ImageConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerServiceSourceConfigurationImageRepository), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepository")]
        internal sealed class _Proxy : DeputyBase, aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepository
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#image_identifier ApprunnerService#image_identifier}.</summary>
            [JsiiProperty(name: "imageIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#image_repository_type ApprunnerService#image_repository_type}.</summary>
            [JsiiProperty(name: "imageRepositoryType", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageRepositoryType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>image_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#image_configuration ApprunnerService#image_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration\"}", isOptional: true)]
            public aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration? ImageConfiguration
            {
                get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration?>();
            }
        }
    }
}
