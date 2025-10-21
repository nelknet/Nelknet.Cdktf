using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTlsCertificateAcm")]
    public class AppmeshVirtualNodeSpecListenerTlsCertificateAcm : aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTlsCertificateAcm
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#certificate_arn AppmeshVirtualNode#certificate_arn}.</summary>
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateArn
        {
            get;
            set;
        }
    }
}
