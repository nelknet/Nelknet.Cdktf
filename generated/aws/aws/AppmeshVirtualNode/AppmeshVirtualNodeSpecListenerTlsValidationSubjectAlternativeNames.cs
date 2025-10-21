using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNames")]
    public class AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNames : aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNames
    {
        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#match AppmeshVirtualNode#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch\"}")]
        public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch Match
        {
            get;
            set;
        }
    }
}
