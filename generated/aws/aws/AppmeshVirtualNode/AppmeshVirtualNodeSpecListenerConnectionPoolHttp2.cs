using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolHttp2")]
    public class AppmeshVirtualNodeSpecListenerConnectionPoolHttp2 : aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp2
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#max_requests AppmeshVirtualNode#max_requests}.</summary>
        [JsiiProperty(name: "maxRequests", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxRequests
        {
            get;
            set;
        }
    }
}
