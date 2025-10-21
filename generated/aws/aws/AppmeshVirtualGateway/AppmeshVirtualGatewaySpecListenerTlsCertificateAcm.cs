using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerTlsCertificateAcm")]
    public class AppmeshVirtualGatewaySpecListenerTlsCertificateAcm : aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerTlsCertificateAcm
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#certificate_arn AppmeshVirtualGateway#certificate_arn}.</summary>
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateArn
        {
            get;
            set;
        }
    }
}
