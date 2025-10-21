using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority")]
    public interface IEcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#aws_pca_authority_arn EcsService#aws_pca_authority_arn}.</summary>
        [JsiiProperty(name: "awsPcaAuthorityArn", typeJson: "{\"primitive\":\"string\"}")]
        string AwsPcaAuthorityArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#aws_pca_authority_arn EcsService#aws_pca_authority_arn}.</summary>
            [JsiiProperty(name: "awsPcaAuthorityArn", typeJson: "{\"primitive\":\"string\"}")]
            public string AwsPcaAuthorityArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
