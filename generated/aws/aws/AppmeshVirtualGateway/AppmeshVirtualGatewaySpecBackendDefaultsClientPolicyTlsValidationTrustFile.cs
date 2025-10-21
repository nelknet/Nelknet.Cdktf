using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidationTrustFile")]
    public class AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidationTrustFile : aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidationTrustFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#certificate_chain AppmeshVirtualGateway#certificate_chain}.</summary>
        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateChain
        {
            get;
            set;
        }
    }
}
