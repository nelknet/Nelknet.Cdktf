using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority")]
    public class EcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority : aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#aws_pca_authority_arn EcsService#aws_pca_authority_arn}.</summary>
        [JsiiProperty(name: "awsPcaAuthorityArn", typeJson: "{\"primitive\":\"string\"}")]
        public string AwsPcaAuthorityArn
        {
            get;
            set;
        }
    }
}
