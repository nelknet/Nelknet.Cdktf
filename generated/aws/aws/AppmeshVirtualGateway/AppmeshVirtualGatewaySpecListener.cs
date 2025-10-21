using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListener")]
    public class AppmeshVirtualGatewaySpecListener : aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListener
    {
        /// <summary>port_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#port_mapping AppmeshVirtualGateway#port_mapping}
        /// </remarks>
        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerPortMapping\"}")]
        public aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerPortMapping PortMapping
        {
            get;
            set;
        }

        /// <summary>connection_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#connection_pool AppmeshVirtualGateway#connection_pool}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionPool", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPool\"}", isOptional: true)]
        public aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPool? ConnectionPool
        {
            get;
            set;
        }

        /// <summary>health_check block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#health_check AppmeshVirtualGateway#health_check}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerHealthCheck\"}", isOptional: true)]
        public aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerHealthCheck? HealthCheck
        {
            get;
            set;
        }

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#tls AppmeshVirtualGateway#tls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerTls\"}", isOptional: true)]
        public aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerTls? Tls
        {
            get;
            set;
        }
    }
}
