using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackend")]
    public class AppmeshVirtualNodeSpecBackend : aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackend
    {
        /// <summary>virtual_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#virtual_service AppmeshVirtualNode#virtual_service}
        /// </remarks>
        [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackendVirtualService\"}")]
        public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendVirtualService VirtualService
        {
            get;
            set;
        }
    }
}
