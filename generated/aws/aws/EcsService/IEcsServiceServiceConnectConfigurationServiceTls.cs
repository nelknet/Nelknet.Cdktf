using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceServiceConnectConfigurationServiceTls), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceTls")]
    public interface IEcsServiceServiceConnectConfigurationServiceTls
    {
        /// <summary>issuer_cert_authority block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#issuer_cert_authority EcsService#issuer_cert_authority}
        /// </remarks>
        [JsiiProperty(name: "issuerCertAuthority", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority\"}")]
        aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority IssuerCertAuthority
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#kms_key EcsService#kms_key}.</summary>
        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#role_arn EcsService#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceServiceConnectConfigurationServiceTls), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceTls")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>issuer_cert_authority block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#issuer_cert_authority EcsService#issuer_cert_authority}
            /// </remarks>
            [JsiiProperty(name: "issuerCertAuthority", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority\"}")]
            public aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority IssuerCertAuthority
            {
                get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#kms_key EcsService#kms_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#role_arn EcsService#role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
