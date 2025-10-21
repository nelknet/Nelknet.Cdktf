using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualRouter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListener")]
    public class AppmeshVirtualRouterSpecListener : aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListener
    {
        /// <summary>port_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#port_mapping AppmeshVirtualRouter#port_mapping}
        /// </remarks>
        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListenerPortMapping\"}")]
        public aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListenerPortMapping PortMapping
        {
            get;
            set;
        }
    }
}
