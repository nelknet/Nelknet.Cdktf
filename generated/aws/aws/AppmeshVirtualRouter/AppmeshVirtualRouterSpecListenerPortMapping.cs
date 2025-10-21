using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualRouter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListenerPortMapping")]
    public class AppmeshVirtualRouterSpecListenerPortMapping : aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListenerPortMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#port AppmeshVirtualRouter#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#protocol AppmeshVirtualRouter#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }
    }
}
