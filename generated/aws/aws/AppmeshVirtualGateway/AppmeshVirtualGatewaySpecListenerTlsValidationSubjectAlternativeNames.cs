using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNames")]
    public class AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNames : aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNames
    {
        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#match AppmeshVirtualGateway#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatch\"}")]
        public aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatch Match
        {
            get;
            set;
        }
    }
}
