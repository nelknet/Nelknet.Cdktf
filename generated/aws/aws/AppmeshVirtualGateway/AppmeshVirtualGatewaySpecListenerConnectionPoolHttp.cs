using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp")]
    public class AppmeshVirtualGatewaySpecListenerConnectionPoolHttp : aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#max_connections AppmeshVirtualGateway#max_connections}.</summary>
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxConnections
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#max_pending_requests AppmeshVirtualGateway#max_pending_requests}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPendingRequests", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPendingRequests
        {
            get;
            set;
        }
    }
}
