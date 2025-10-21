using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTls")]
    public class AppmeshVirtualNodeSpecListenerTls : aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTls
    {
        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#certificate AppmeshVirtualNode#certificate}
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTlsCertificate\"}")]
        public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTlsCertificate Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#mode AppmeshVirtualNode#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>validation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#validation AppmeshVirtualNode#validation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validation", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTlsValidation\"}", isOptional: true)]
        public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTlsValidation? Validation
        {
            get;
            set;
        }
    }
}
