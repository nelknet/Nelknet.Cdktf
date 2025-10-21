using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualService
{
    [JsiiByValue(fqn: "aws.appmeshVirtualService.AppmeshVirtualServiceSpecProvider")]
    public class AppmeshVirtualServiceSpecProvider : aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProvider
    {
        /// <summary>virtual_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#virtual_node AppmeshVirtualService#virtual_node}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNode", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualNode\"}", isOptional: true)]
        public aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualNode? VirtualNode
        {
            get;
            set;
        }

        /// <summary>virtual_router block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#virtual_router AppmeshVirtualService#virtual_router}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualRouter", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualRouter\"}", isOptional: true)]
        public aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualRouter? VirtualRouter
        {
            get;
            set;
        }
    }
}
