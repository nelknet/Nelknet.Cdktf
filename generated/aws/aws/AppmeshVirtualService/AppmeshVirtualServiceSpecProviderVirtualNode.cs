using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualNode")]
    public class AppmeshVirtualServiceSpecProviderVirtualNode : aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualNode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#virtual_node_name AppmeshVirtualService#virtual_node_name}.</summary>
        [JsiiProperty(name: "virtualNodeName", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualNodeName
        {
            get;
            set;
        }
    }
}
