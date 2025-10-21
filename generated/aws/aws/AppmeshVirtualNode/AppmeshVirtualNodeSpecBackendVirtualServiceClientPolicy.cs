using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiByValue(fqn: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicy")]
    public class AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicy : aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicy
    {
        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#tls AppmeshVirtualNode#tls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTls\"}", isOptional: true)]
        public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTls? Tls
        {
            get;
            set;
        }
    }
}
