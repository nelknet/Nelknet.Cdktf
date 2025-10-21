using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpc")]
    public class AppmeshVirtualGatewaySpecListenerConnectionPoolGrpc : aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#max_requests AppmeshVirtualGateway#max_requests}.</summary>
        [JsiiProperty(name: "maxRequests", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxRequests
        {
            get;
            set;
        }
    }
}
