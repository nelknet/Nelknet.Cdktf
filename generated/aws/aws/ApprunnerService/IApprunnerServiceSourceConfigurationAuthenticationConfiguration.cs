using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiInterface(nativeType: typeof(IApprunnerServiceSourceConfigurationAuthenticationConfiguration), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceSourceConfigurationAuthenticationConfiguration")]
    public interface IApprunnerServiceSourceConfigurationAuthenticationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#access_role_arn ApprunnerService#access_role_arn}.</summary>
        [JsiiProperty(name: "accessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#connection_arn ApprunnerService#connection_arn}.</summary>
        [JsiiProperty(name: "connectionArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerServiceSourceConfigurationAuthenticationConfiguration), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceSourceConfigurationAuthenticationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ApprunnerService.IApprunnerServiceSourceConfigurationAuthenticationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#access_role_arn ApprunnerService#access_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#connection_arn ApprunnerService#connection_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
