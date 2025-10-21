using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualRouter")]
    public class AppmeshVirtualServiceSpecProviderVirtualRouter : aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualRouter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#virtual_router_name AppmeshVirtualService#virtual_router_name}.</summary>
        [JsiiProperty(name: "virtualRouterName", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualRouterName
        {
            get;
            set;
        }
    }
}
