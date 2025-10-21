using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualService
{
    [JsiiByValue(fqn: "aws.appmeshVirtualService.AppmeshVirtualServiceSpec")]
    public class AppmeshVirtualServiceSpec : aws.AppmeshVirtualService.IAppmeshVirtualServiceSpec
    {
        /// <summary>provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#provider AppmeshVirtualService#provider}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProvider\"}", isOptional: true)]
        public aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProvider? Provider
        {
            get;
            set;
        }
    }
}
